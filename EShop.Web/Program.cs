using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using EShop.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using EShop.Application.Services.Interfaces;
using EShop.Application.Services.Implementations;
using EShop.Domain.IRepositories;
using EShop.Data.Repositories;

#region service pool

//ConfigureServices method

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<EShopDbContext>(options =>
options.UseSqlServer(
builder.Configuration.GetConnectionString("DefaultConnection")
));

//builder.Services.AddTransient<IUserService, UserService>(); //Ioc implementations

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
#endregion


#region middlewares


//Configure method
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

#endregion
