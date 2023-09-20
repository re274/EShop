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

        #endregion

        #region products
        void AddProduct(Product product);
        FilterProductViewModel FilterProducts(FilterProductViewModel filter);
        #endregion
    }
}
