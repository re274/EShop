using EShop.Application.Services.Interfaces;
using EShop.Domain.ViewModels.Admin.Products;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Areas.Admin.Controllers
{
    public class ProductController : AdminBaseController
    {
        #region constructor
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        #endregion

        #region create product
        public IActionResult Create()
        {
            ViewBag.ProductCategories = _productService.GetAllActiveProductCategories();
            return View();
        }

        [HttpPost,ValidateAntiForgeryToken] 
        public IActionResult Create(CreateProductViewModel product)
        {
            if(ModelState.IsValid)
            {
                _productService.CreateProduct(product);
            }

            ViewBag.ProductCategories = _productService.GetAllActiveProductCategories();

            return View(product);
        }
        #endregion
    }
}
