using EShop.Data.DBContext;
using EShop.Domain.Entities.Products;
using EShop.Domain.IRepositories;
using EShop.Domain.ViewModels.Admin.Products;
using EShop.Domain.ViewModels.Paging;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        #region constructor
        private readonly EShopDbContext _context;
        public ProductRepository(EShopDbContext context)
        {
            _context = context;
        }
        #endregion

        #region categories
        public List<ProductCategory> GetAllActiveProductCategories()
        {
            return _context.ProductCategories.Where(c => c.IsActive && !c.IsDelete).ToList();
        }

        public void AddProductSelectedCategories(List<ProductSelectedCategory> categories)
        {
            _context.AddRange(categories);
        }
        #endregion

        #region products
        public void AddProduct(Product product)
        {
            _context.Add(product);
        }

        public FilterProductViewModel FilterProducts(FilterProductViewModel filter)
        {
            var query = _context.Products.AsQueryable<Product>();

            switch (filter.OrderBy)
            {
                case FilterProductOrder.CreateDate_Asc:
                    query = query.OrderBy(s => s.CreateDate);
                    break;
                case FilterProductOrder.CreateDate_Des:
                    query = query.OrderByDescending(s => s.CreateDate);
                    break;
                case FilterProductOrder.Price_Asc:
                    query = query.OrderBy(s => s.Price);
                    break;
                case FilterProductOrder.Price_Des:
                    query = query.OrderByDescending(s => s.Price);
                    break;
                case FilterProductOrder.ExistsProducts:
                    query = query.OrderByDescending(s => s.Inventory);
                    break;
            }

            switch (filter.State)
            {
                case FilterProductState.All:
                    break;
                case FilterProductState.ActiveProducts:
                    query = query.Where(s => s.IsActive);
                    break;
                case FilterProductState.DeletedProducts:
                    query = query.Where(s => s.IsDelete);
                    break;
                case FilterProductState.ExistsProducts:
                    query = query.Where(s => s.Inventory > 0);
                    break;
            }

            if (!string.IsNullOrEmpty(filter.Title))
            {
                query = query.Where(s => EF.Functions.Like(s.Title, $"%{filter.Title}%"));
                //query = query.Where(s => s.Title.Contains(filter.Title));
            }

            //Implementation of pagination
            var allEntitiesCount = query.Count();
            var pager = Pager.Build(filter.Page, allEntitiesCount, filter.Take, filter.HowManyPagesShowAfterBefore);
            var products = query.Paging(pager).ToList();

            filter.Products = products;
            return filter.SetPaging(pager);
        }

        #endregion

        #region save changes
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        #endregion
    }
}
