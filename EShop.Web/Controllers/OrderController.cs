using EShop.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

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
        [HttpGet("add-product-to-order")]
        public IActionResult AddProductToOrder(int productId, int count)
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = Convert.ToInt32(User.Claims.SingleOrDefault(s => s.Type == ClaimTypes.NameIdentifier).Value);
                var res = _orderService.AddProductToUserOrder(userId, productId, count);
                return new JsonResult(new
                {
                    message = "محصول مورد نظر با موفقیت به سبد خرید اضافه شد",
                    status = "Added successfully"
                });
            }
            else
            {
                return new JsonResult(new
                {
                    message = "برای ثبت محصول در سبد خرید، باید وارد شوید",
                    status = "MustLogin"
                });
            }
        }
        #endregion
    }
}
