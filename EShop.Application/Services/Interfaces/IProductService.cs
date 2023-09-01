using EShop.Domain.Entities.Products;
using System.Collections.Generic;

namespace EShop.Application.Services.Interfaces
{
    public interface IProductService
    {
        #region categories

        List<ProductCategory> GetAllActiveProductCategories();

        #endregion
    }
}
