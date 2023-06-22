using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly EShopDbContext _context;

        //public HomeController(EShopDbContext context)
        //{
        //    _context = context;
        //}


        //private readonly IUserService _userService;

        //public HomeController(IUserService userService)
        //{
        //    _userService= userService;
        //}

       
        
        public IActionResult Index()
        {

            //var user = new User
            //{
            //    FirstName = "Reyhaneh",
            //    LastName = "Khalili",
            //    Email = "test@test.com",
            //    Password = "123456",
            //    Avatar = null
            //};

            //_context.Users.Add(user);
            //_context.SaveChanges();

            //_userService.AddUser();

            return View();
        }
    }
}
