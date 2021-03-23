using MenuApp.MenuService.EntityFramework.Data;
using MenuApp.MenuService.Logic.Interfaces.Repository;

namespace MenuApp.MenuService.EntityFramework.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly AppDbContext _db;

        public MenuRepository(AppDbContext db)
        {
            _db = db;
        }
    }
}