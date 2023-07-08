using EShop.Domain.Entities.Account;
using EShop.Domain.IRepositories;


namespace EShop.Domain.IRepositories 
{
    public interface IUserRepository : ISaveChangesRepository
    {
        //CRUD operation only
        #region user
        void AddUser(User user);
        bool IsUserExistsByEmail(string email);
        #endregion

    }
}
