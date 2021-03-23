using MenuApp.MenuService.Logic.Entities;
using Microsoft.EntityFrameworkCore;

namespace MenuApp.MenuService.EntityFramework.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}