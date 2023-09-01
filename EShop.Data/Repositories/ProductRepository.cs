using EShop.Data.DBContext;
using EShop.Domain.Entities.Products;
using EShop.Domain.IRepositories;
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

        #endregion

        #region save changes
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        #endregion




    }
}
