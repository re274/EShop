using EShop.Domain.Entities.Products;
using EShop.Domain.ViewModels.Admin.Products;
using System.Collections.Generic;

namespace EShop.Domain.IRepositories
{
    public interface IProductRepository : ISaveChangesRepository
    {
        #region categories
        List<ProductCategory> GetAllActiveProductCategories();
        void AddProductSelectedCategories(List<ProductSelectedCategory> categories);
        List<ProductCategory> GetProductSelectedCategories(int productId);
        #endregion

        #region products
        void AddProduct(Product product);
        Product GetProductById(int productId);
        FilterProductViewModel FilterProducts(FilterProductViewModel filter);
        #endregion
    }
}
