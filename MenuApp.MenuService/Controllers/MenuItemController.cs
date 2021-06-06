using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using MenuApp.MenuService.Logic.Entities;
using MenuApp.MenuService.Logic.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MenuApp.MenuService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuItemController
    {
        private readonly IMenuRepository _menuRepository;

        public MenuItemController(IMenuRepository menuRepository)
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