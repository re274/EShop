using EShop.Data.DBContext;
using EShop.Domain.Entities.Site;
using EShop.Domain.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Data.Repositories
{
    public class SiteRepository : ISiteRepository
    {
        #region constructor
        private readonly EShopDbContext _context;
        public SiteRepository(EShopDbContext context)
        {
            _context = context;
        }
        #endregion

        #region slider
        public List<Slider> GetAllActiveSliders()
        {
            return _context.Sliders.Where(s => s.IsActive && !s.IsDelete).ToList();
        }
        #endregion

        #region save changes
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        #endregion
    }
}
