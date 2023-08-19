using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Areas.Admin.Controllers
{
	public class HomeController : AdminBaseController
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
