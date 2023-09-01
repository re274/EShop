using EShop.Application.Services.Interfaces;
using EShop.Domain.Entities.Products;
using EShop.Domain.IRepositories;
using System.Collections.Generic;

namespace EShop.Application.Services.Implementations
{
    public class ProductService : IProductService
    {
        #region constructor
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        #endregion


        #region categories

        public List<ProductCategory> GetAllActiveProductCategories()
        {
            return _productRepository.GetAllActiveProductCategories();
        }

        #endregion
    }
}
