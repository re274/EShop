using EShop.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Controllers
{
    public class HomeController : Controller
    {
        #region constructor
        private readonly IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }
    }
}
