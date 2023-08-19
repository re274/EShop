using Microsoft.AspNetCore.Mvc;

namespace CampEshop.Web.Areas.Admin.ViewComponents
{
    public class AdminRightSideViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AdminRightSide");
        }
    }
}
