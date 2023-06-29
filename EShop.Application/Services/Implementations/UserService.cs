using EShop.Application.Services.Interfaces;
using EShop.Domain.Entities.Account;
using EShop.Domain.IRepositories;
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
        public bool RegisterUser(User user)
        {
            //add user data to database
            _userRepository.AddUser(user);
            _userRepository.SaveChanges();

            //send activation email/sms to user

            //return result
            return true;
        }
        #endregion    
    }
}
