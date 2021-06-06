using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MenuApp.MenuService.Logic.Entities;

namespace MenuApp.MenuService.Logic.Interfaces.Repository
{
    public interface IMenuRepository
    {
        public Task<List<MenuItem>> GetAll();

        public Task<MenuItem> GetById(Guid id);
    }
}