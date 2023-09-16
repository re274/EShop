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

        #region filter products
        public IActionResult index()
        {
            return View();
        }
        #endregion

        #region create product
        public IActionResult Create()
        {
            ViewBag.ProductCategories = _productService.GetAllActiveProductCategories();
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(CreateProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var res = _productService.CreateProduct(product);
                switch (res)
                {
                    case CreateProductResult.InvalidImage:
                        TempData[ErrorMessage] = "تصویر وارد شده، معتبر نمی باشد";
                        break;
                    case CreateProductResult.Success:
                        TempData[SuccessMessage] = "محصول مورد نظر با موفقیت درج شد";
                        return RedirectToAction("Index");
                }
            }

            ViewBag.ProductCategories = _productService.GetAllActiveProductCategories();

            return View(product);
        }
        #endregion
    }
}
