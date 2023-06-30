using EShop.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using EShop.Domain.Entities.Account;

namespace EShop.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly EShopDbContext _context;

        //public HomeController(EShopDbContext context)
        //{
        //    _context = context;
        //}


        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }



        public IActionResult Index()
        {


            return View();
        }
    }
}
