using EShop.Data.DBContext;
using EShop.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        #region constructor
        private readonly EShopDbContext _context;
        public ProductRepository(EShopDbContext context)
        {
            _context = context;
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
