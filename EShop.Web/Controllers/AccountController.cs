using EShop.Application.Services.Interfaces;
using EShop.Domain.IRepositories;
using EShop.Domain.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Controllers
{
    public class AccountController : SiteBaseController
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
                        TempData[SuccessMessage] = "ثبت نام شما با موفقیت انجام شد";
                        TempData[WarningMessage] = "ایمیل فعالسازی برای شما ارسال نشد";
                        break;
                    case RegisterUserResult.DuplicateEmail:
                        TempData[WarningMessage] = "این ایمیل قبلا استفاده شده است";
                        ModelState.AddModelError("Email", "ایمیل استفاده شده، تکراری می باشد");
                        break;
                    case RegisterUserResult.Success:
                        TempData[SuccessMessage] = "ثبت نام شما با موفقیت انجام شد";
                        TempData[InfoMessage] = "ایمیلی حاوی لینک فعالسازی برای شما ارسال شده است";
                        return RedirectToAction("Login");
                }
            }
            return View();
        }
        #endregion


        #region login

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        #endregion
    }
}
