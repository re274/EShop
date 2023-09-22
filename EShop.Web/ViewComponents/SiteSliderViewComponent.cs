using EShop.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.ViewComponents
{
    public class SiteSliderViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;
        public SiteSliderViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public IViewComponentResult Invoke()
        {
            return View("SiteSlider", _siteService.GetAllActiveSliders());
        }

        //public Task<IViewComponentResult> InvokeAsync()
        //{
        //    return Task.FromResult<IViewComponentResult>(View("SiteSlider", _siteService.GetAllActiveSliders));
        //}
    }
}
