using EShop.Domain.Entities.Account;
using EShop.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.DBContext
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductSelectedCategory> ProductSelectedCategories { get; set; }

    }
}

