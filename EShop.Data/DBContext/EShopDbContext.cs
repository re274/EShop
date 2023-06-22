using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Domain.Entities.Account;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.DBContext
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}

