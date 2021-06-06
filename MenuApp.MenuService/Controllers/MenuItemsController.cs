using System.Collections.Generic;
using System.Threading.Tasks;
using MenuApp.MenuService.Logic.Entities;
using MenuApp.MenuService.Logic.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MenuApp.MenuService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuItemsController
    {
        private readonly IMenuRepository _menuRepository;

        public MenuItemsController(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }
        
        [HttpGet]
        public async Task<List<MenuItem>> Get()
        {
            return await _menuRepository.GetAll();
        }
    }
}