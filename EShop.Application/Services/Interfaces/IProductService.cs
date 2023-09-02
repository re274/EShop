using EShop.Domain.Entities.Products;
using EShop.Domain.ViewModels.Admin.Products;
using System.Collections.Generic;

namespace EShop.Application.Services.Interfaces
{
    public interface IProductService
    {
        #region categories

        List<ProductCategory> GetAllActiveProductCategories();
        void AddProductSelectedCategories(int productId, List<int> categoryIds);
        #endregion

        #region products

        CreateProductResult CreateProduct(CreateProductViewModel product);

        #endregion
    }
}
