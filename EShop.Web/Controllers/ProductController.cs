using EShop.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Controllers
{
    public class ProductController : SiteBaseController
    {
        #region constructor
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        #endregion

        [HttpGet("product/{productId}/{productTitle}")]
        public IActionResult ProductDetail(int productId, string productTitle)
        {
            var product = _productService.GetproductDetail(productId);
            if (product == null) { return NotFound(); }
            return View(product);
        }
    }
}
