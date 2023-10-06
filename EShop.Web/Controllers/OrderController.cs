using EShop.Application.Services.Interfaces;
using EShop.Domain.Entities.Products;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Controllers
{
    public class OrderController : SiteBaseController
    {
        #region constructor
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        #endregion

        #region add product to order

        #endregion
        [HttpGet("add-product-to-order")]
        public IActionResult AddProductToOrder(int productId, int count)
        {
            if(User.Identity.IsAuthenticated)
            {
                return new JsonResult(new
                {
                    //ProductId = productId,
                    //Count = count
                    message = "شما وارد سایت شده اید"
                });
            }
            else
            {
                return new JsonResult(new
                {
                    //ProductId = productId,
                    //Count = count
                    message = "برای ثبت محصول در سبد خرید، باید وارد شوید"
                });
            }
        }
    }
}
