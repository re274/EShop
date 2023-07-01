using EShop.Domain.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Controllers
{
    public class AccountController : Controller
    {
        #region register
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost("register")]
        public IActionResult Register(RegisterUserViewModel register)
        {
            return View();
        }
        #endregion
    }
}
