using EShop.Application.Extensions;
using EShop.Application.Security;
using EShop.Application.Services.Interfaces;
using EShop.Application.StaticItems;
using EShop.Domain.Entities.Products;
using EShop.Domain.IRepositories;
using EShop.Domain.ViewModels.Admin.Products;
using EShop.Domain.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.IO;
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

            // add image
            if (product.ProductImage != null)
            {
                if (!product.ProductImage.IsImage()) return CreateProductResult.InvalidImage;

                var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(product.ProductImage.FileName);

                product.ProductImage.AddImageToServer(
                    imageName,
                    PathTools.ProductImageUploadPath,
                    150, 150,
                    PathTools.ProductThumbImageUploadPath);

                newProduct.ImageName = imageName;
            }
            _productRepository.AddProduct(newProduct);
            _productRepository.SaveChanges();

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

        public FilterProductViewModel FilterProduct(FilterProductViewModel filter)
        {
            return _productRepository.FilterProducts(filter);
        }

        public ProductDetailViewModel GetproductDetail(int productId)
        {
            var product = _productRepository.GetProductById(productId);

            if (product == null || product.IsDelete || !product.IsActive)
            {
                return null;
            }

            return new ProductDetailViewModel
            {
                Id = product.Id,
                Title = product.Title,
                ShortDescription = product.ShortDescription,
                Description = product.Description,
                ImageName = product.ImageName,
                Price = product.Price,
                ProductCategories = _productRepository.GetProductSelectedCategories(productId)
            };
        }
        #endregion
    }
}
