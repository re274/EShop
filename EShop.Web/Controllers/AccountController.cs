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


        [HttpPost("register"), ValidateAntiForgeryToken]
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
                        return RedirectToAction("Login", "Account");
                }
            }
            return View(register);
        }
        #endregion


        #region login

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login"), ValidateAntiForgeryToken]
        public IActionResult Login(LoginUserViewModel login)
        {
            if (ModelState.IsValid)
            {
                var res = _userService.IsUserExistsForLogin(login);
                switch (res)
                {
                    case LoginUserResult.WrongData:
                        TempData[WarningMessage] = "اطلاعات وارد شده صحیح نمی باشد";
                        break;
                    case LoginUserResult.NotActive:
                        TempData[WarningMessage] = "حساب کاربری شما فعال نشده است";
                        break;
                    case LoginUserResult.IsBan:
                        TempData[ErrorMessage] = "حساب کاربری شما مسدود شده است";
                        break;
                    case LoginUserResult.Success:
                        // login user
                        return RedirectToAction("Index", "Home");

                }
            }
            return View(login);
        }

        #endregion
    }
}
