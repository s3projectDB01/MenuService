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
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            
            MenuItem item1 = new MenuItem
            {
                Id = Guid.NewGuid(),
                Name = "Tomatensoep",
                Type = "Voor",
                Ingredients = new List<Guid> {Guid.NewGuid(),Guid.NewGuid()},
                Price = 12.15
            };
            MenuItem item2 = new MenuItem
            {
                Id = Guid.NewGuid(),
                Name = "Biefstuk",
                Type = "Hoofd",
                Ingredients = new List<Guid> {Guid.NewGuid(),Guid.NewGuid()},
                Price = 67.15
            };
            MenuItem item3 = new MenuItem
            {
                Id = Guid.NewGuid(),
                Name = "Creme Brulee",
                Type = "Na",
                Ingredients = new List<Guid> {Guid.NewGuid(),Guid.NewGuid()},
                Price = 100.15
            };

            List<MenuItem> menu = new List<MenuItem>();
            menu.Add(item1);
            menu.Add(item2);
            menu.Add(item3);
            return menu;
            //return await _menuRepository.GetALl();
        }
    }
}