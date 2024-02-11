using EShop.Domain.Entities.Account;
using EShop.Domain.ViewModels.Account;

namespace EShop.Application.Services.Interfaces
{
    public interface IUserService
    {
        #region account
        RegisterUserResult RegisterUser(RegisterUserViewModel register);
        LoginUserResult IsUserExistsForLogin(LoginUserViewModel login);
        User GetUserByEmail(string email);
        ForgotPasswordResult ForgotPassword(ForgotPasswordViewModel forgot);
        EditUserViewModel GetUserForEdit(int userId);
        #endregion
    }
}

