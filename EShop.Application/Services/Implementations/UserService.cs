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
            //add user to database
            var user = new User
            {
                Email = register.Email,
                Password = register.Password,
                RegisterDate = DateTime.Now,
            };
            _userRepository.AddUser(user);
            _userRepository.SaveChanges();

            // TODO: send email to user(activation code)

            return RegisterUserResult.Success;
        }

        #endregion

    }
}
