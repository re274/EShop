using EShop.Application.Services.Interfaces;
using EShop.Domain.Entities.Products;
using EShop.Domain.IRepositories;
using EShop.Domain.ViewModels.Admin.Products;
using System.Collections.Generic;
using System.Linq;

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

        #region products

        public CreateProductResult CreateProduct(CreateProductViewModel product)
        {
            // add product
            var newProduct = new Product
            {
                Title = product.Title,
                Description = product.Description,
                ShortDescription = product.ShortDescription,
                ImageName = "",
                Price = product.Price
            };
            _productRepository.AddProduct(newProduct);
            _productRepository.SaveChanges();

            // add image

            // add categories
            AddProductSelectedCategories(newProduct.Id, product.SelectedCategories);

            return CreateProductResult.Success;
        }

        public void AddProductSelectedCategories(int productId, List<int> categoryIds)
        {
            if (categoryIds != null && categoryIds.Any())
            {
                var selectedCategories = new List<ProductSelectedCategory>();
                foreach (var categoryId in categoryIds)
                {
                    selectedCategories.Add(new ProductSelectedCategory
                    {
                        ProductId = productId,
                        ProductCategoryId = categoryId
                    });
                }
                _productRepository.AddProductSelectedCategories(selectedCategories);
                _productRepository.SaveChanges();
            }
        }

        #endregion
    }
}
