using EShop.Domain.Entities.Account;
using EShop.Domain.IRepositories;


namespace EShop.Domain.IRepositories
{
    public interface IUserRepository : ISaveChangesRepository
    {
        //CRUD operation only
        #region user
        void AddUser(User user);
        void EditUser(User user);
        bool IsUserExistsByEmail(string email);
        User GetUserByEmail(string email);

        #endregion

    }
}
