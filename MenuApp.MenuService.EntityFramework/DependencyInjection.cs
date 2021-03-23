using System;
using MenuApp.MenuService.EntityFramework.Data;
using MenuApp.MenuService.EntityFramework.Repository;
using MenuApp.MenuService.Logic.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace MenuApp.MenuService.EntityFramework
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseMySql(
                        connectionString,
                        new MariaDbServerVersion(new Version(10, 5, 9)),
                        mysqlOptions => mysqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            });

            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IIngredientRepository, IngredientRepository>();
            
            return services;
        }
    }
}