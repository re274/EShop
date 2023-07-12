using EShop.Application.Services.Interfaces;
using EShop.Data.Repositories;
using EShop.Domain.Entities.Account;
using EShop.Domain.IRepositories;
using EShop.Domain.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        #region constructor
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion

        #region account

        public RegisterUserResult RegisterUser(RegisterUserViewModel register)
        {
            //check user is unique
            if(_userRepository.IsUserExistsByEmail(register.Email))
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
            throw new NotImplementedException();
        } 

        #endregion

    }
}
