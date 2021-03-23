using MenuApp.MenuService.EntityFramework.Data;
using MenuApp.MenuService.Logic.Interfaces.Repository;

namespace MenuApp.MenuService.EntityFramework.Repository
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly AppDbContext _db;

        public IngredientRepository(AppDbContext db)
        {
            _db = db;
        }
    }
}