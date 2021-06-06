using System.Collections.Generic;
using System.Threading.Tasks;
using MenuApp.MenuService.EntityFramework.Data;
using MenuApp.MenuService.Logic.Entities;
using MenuApp.MenuService.Logic.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace MenuApp.MenuService.EntityFramework.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly AppDbContext _db;

        public MenuRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<MenuItem>> GetAll()
        {
            return await _db.MenuItems.Include(x => x.Ingredients).ToListAsync();
        }
    }
}