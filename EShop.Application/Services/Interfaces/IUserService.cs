using EShop.Domain.Entities.Account;
using EShop.Domain.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Services.Interfaces
{
    public interface IUserService
    {
        #region account
        void RegisterUser(RegisterUserViewModel register);
        #endregion
    }
}

