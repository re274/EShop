using EShop.Domain.Entities.Account;
using EShop.Domain.Entities.ProductOrder;
using EShop.Domain.Entities.Products;
using EShop.Domain.Entities.Site;
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

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}

