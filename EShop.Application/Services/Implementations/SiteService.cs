using EShop.Application.Services.Interfaces;
using EShop.Domain.Entities.Site;
using EShop.Domain.IRepositories;
using System.Collections.Generic;

namespace EShop.Application.Services.Implementations
{
    public class SiteService : ISiteService
    {
        #region constructor
        private readonly ISiteRepository _siteRepository;
        public SiteService(ISiteRepository siteRepository)
        {
            _siteRepository = siteRepository;
        }
        #endregion

        #region slider
        public List<Slider> GetAllActiveSliders()
        {
            return _siteRepository.GetAllActiveSliders();
        }
        #endregion
    }
}
