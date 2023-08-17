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

            // service dependencies
            services.AddScoped<IUserService, UserService>();
        }

    }
}
