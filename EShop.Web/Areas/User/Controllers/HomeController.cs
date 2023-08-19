using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Areas.User.Controllers
{
    public class HomeController : UserBaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("edit-profile")]
		public IActionResult EditProfile()
		{
			return View();
		}
	}
}
