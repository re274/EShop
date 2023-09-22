using EShop.Domain.Entities.Site;
using System.Collections.Generic;

namespace EShop.Application.Services.Interfaces
{
    public interface ISiteService
    {
        #region slider
        List<Slider> GetAllActiveSliders();
        #endregion
    }
}
