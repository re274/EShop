﻿using EShop.Domain.IRepositories;
using EShop.Domain.Entities.Account;
using EShop.Data.DBContext;
using System.Linq;

namespace EShop.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        //CRUD operation only

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

        public bool IsUserExistsByEmail(string email)
        {
            return _context.Users.Any(s=>s.Email == email.ToLower().Trim());
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
