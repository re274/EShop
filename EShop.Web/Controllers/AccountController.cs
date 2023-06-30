using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Controllers
{
    public class AccountController : Controller
    {
        #region register
        public IActionResult Register()
        {
            return View();
        }
        #endregion

    }
}
