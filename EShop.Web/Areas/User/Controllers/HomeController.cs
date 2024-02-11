using EShop.Application.Services.Interfaces;
using EShop.Domain.ViewModels.Account;
using EShop.Web.HttpContextAccessories;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Areas.User.Controllers
{
    public class HomeController : UserBaseController
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

        [HttpGet("edit-profile")]
        public IActionResult EditProfile()
        {
            var user = _userService.GetUserForEdit(User.GetUserId());
            return View(user);
        }

        [HttpPost("edit-profile"), ValidateAntiForgeryToken]
        public IActionResult EditProfile(EditUserViewModel user)
        {
            return View(user);
        }
    }
}
