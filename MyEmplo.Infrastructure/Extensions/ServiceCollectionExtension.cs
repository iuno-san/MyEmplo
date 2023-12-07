using MyEmplo.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEmplo.Infrastructure.Seeders;
using MyEmplo.Infrastructure.Repositories;
using MyEmplo.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;
using MyEmplo.Application.ApplicationUser;

namespace MyEmplo.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserContext, UserContext>();

            services.AddDbContext<MyEmploDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("MyEmploConection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<MyEmploDbContext>();

            services.AddScoped<MyEmploSeeder>();

            services.AddScoped<IMyEmploRepository, MyEmploRepository>();

            services.AddScoped<IMyEmploServiceRepository, MyEmploServiceRepository>();
        }
    }
}
