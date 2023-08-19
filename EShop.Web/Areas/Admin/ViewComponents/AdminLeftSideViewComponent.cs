using Microsoft.AspNetCore.Mvc;

namespace CampEshop.Web.Areas.Admin.ViewComponents
{
    public class AdminLeftSideViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AdminLeftSide");
        }
    }
}
