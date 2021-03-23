using MenuApp.MenuService.EntityFramework.Data;
using MenuApp.MenuService.EntityFramework.Repository;
using MenuApp.MenuService.Logic.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MenuApp.MenuService.EntityFramework
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseNpgsql(connectionString);
            });
         
            services.AddTransient<IMenuRepository, MenuRepository >();
            services.AddTransient<IIngredientRepository, IngredientRepository >();
                     
            return services;
        }
    }
}