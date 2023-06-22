using EShop.Domain.IRepositories;
using EShop.Domain.Entities.Account;
using EShop.Data.DBContext;

namespace EShop.Data.Repositories
{
    public class UserRepository : IUserRepository
    {

        #region constructor
        private readonly EShopDbContext _context;
        public UserRepository(EShopDbContext context)
        {
            _context = context;
        }
        #endregion


        #region user
        public void AddUser(User user)
        {
            _context.Users.Add(user); //.Users Optional
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
