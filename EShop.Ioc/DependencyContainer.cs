using EShop.Application.Services.Implementations;
using EShop.Application.Services.Interfaces;
using EShop.Data.Repositories;
using EShop.Domain.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace EShop.Ioc
{
    public class DependencyContainer
    {
        public static void ConfigureServiceCollection(IServiceCollection services)
        {
            // repository dependencies
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISiteRepository, SiteRepository>();

            // service dependencies
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISiteService, SiteService>();
        }
    }
}
