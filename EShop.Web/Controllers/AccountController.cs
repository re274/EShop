using EShop.Application.Services.Interfaces;
using EShop.Domain.IRepositories;
using EShop.Domain.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Controllers
{
    public class AccountController : Controller
    {
        #region constructor
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion


        #region register
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost("register")]
        public IActionResult Register(RegisterUserViewModel register)
        {
            if (ModelState.IsValid)
            {
                var res = _userService.RegisterUser(register);
                switch (res)
                {
                    case RegisterUserResult.NotSentEmail:
                        break;
                    case RegisterUserResult.DuplicateEmail:
                        break;
                    case RegisterUserResult.Success:
                        break;


                }
            }
            return View();
        }
        #endregion
    }
}
