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
                Name = "Tomatensoep (lekkur)",
                Type = "Voor",
                Ingredients = new List<Ingredient> {new Ingredient(), new Ingredient()},
                Price = 12.15,
                Image = "https://static.ah.nl/static/product/AHI_43545239363939373134_1_LowRes_JPG.JPG?options=399,q85"
            };
            MenuItem item2 = new MenuItem
            {
                Id = Guid.NewGuid(),
                Name = "Biefstuk",
                Type = "Hoofd",
                Ingredients = new List<Ingredient> {new Ingredient(), new Ingredient()},
                Price = 67.15,
                Image = "https://static.ah.nl/static/recepten/img_062491_890x594_JPG.jpg"
            };
            MenuItem item3 = new MenuItem
            {
                Id = Guid.NewGuid(),
                Name = "Creme Brulee",
                Type = "Na",
                Ingredients = new List<Ingredient> {new Ingredient(), new Ingredient()},
                Price = 100.15,
                Image = "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/77384360-B5BC-4737-805E-C83023F3F281/Derivates/10B65431-A7A2-4182-831E-C0228FFD3EA7.jpg"
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