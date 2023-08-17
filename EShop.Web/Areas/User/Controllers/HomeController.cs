using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Areas.User.Controllers
{
    public class HomeController : UserBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
