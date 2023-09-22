using EShop.Domain.Entities.Site;
using System.Collections.Generic;

namespace EShop.Domain.IRepositories
{
    public interface ISiteRepository : ISaveChangesRepository
    {
        #region slider
        List<Slider> GetAllActiveSliders();
        #endregion
    }
}
