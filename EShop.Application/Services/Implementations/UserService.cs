using EShop.Application.Services.Interfaces;
using EShop.Domain.Entities.Account;
using EShop.Domain.IRepositories;
using EShop.Domain.ViewModels.Account;
using System;

namespace EShop.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        #region fields
        private readonly IUserRepository _userRepository;
        #endregion

        #region constructor
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion

        #region account
        public RegisterUserResult RegisterUser(RegisterUserViewModel register)
        {
            //check user is unique
            if (_userRepository.IsUserExistsByEmail(register.Email))
                return RegisterUserResult.DuplicateEmail;

            //add user to database
            var user = new User
            {
                Email = register.Email.ToLower().Trim(),
                Password = register.Password,
                RegisterDate = DateTime.Now,
                ActiveCode = Guid.NewGuid().ToString("N"),
            };
            _userRepository.AddUser(user);
            _userRepository.SaveChanges();

            // TODO: send email to user(activation code)

            return RegisterUserResult.Success;
        }

        public LoginUserResult IsUserExistsForLogin(LoginUserViewModel login)
        {
            var user = _userRepository.GetUserByEmail(login.Email);

            if (user == null) return LoginUserResult.WrongData;

            if (user.Password != login.Password) return LoginUserResult.WrongData;

            if (!user.IsActive) return LoginUserResult.NotActive;

            return LoginUserResult.Success;
        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email.ToLower().Trim());
        }

        public ForgotPasswordResult ForgotPassword(ForgotPasswordViewModel forgot)
        {
            var user = _userRepository.GetUserByEmail(forgot.Email.ToLower().Trim());

            if (user == null) return ForgotPasswordResult.NotFoundUser;

            user.ActiveCode = Guid.NewGuid().ToString("N");

            _userRepository.EditUser(user);
            _userRepository.SaveChanges();

            // send forgot email for user

            return ForgotPasswordResult.Success;
        }

        public EditUserViewModel GetUserForEdit(int userId)
        {
            var user = _userRepository.GetUserById(userId);
            if (user == null) return null;
            return new EditUserViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserGender = user.UserGender
            };
        }
        #endregion
    }
}
