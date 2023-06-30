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

    }
}
