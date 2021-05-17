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
                Name = "Tomato soup (tasty)",
                Type = "Soup",
                Ingredients = new List<Ingredient> {new Ingredient{Id = new Guid("7fa82c34-58d7-4e74-8579-01c0af6d3342"), Name = "Tomaten"}, new Ingredient{Id = new Guid("7ea0d151-61d3-4548-b58c-e6b7056e8b12"), Name = "Water"}},
                Price = 12.15,
                Image = "https://static.ah.nl/static/product/AHI_43545239363939373134_1_LowRes_JPG.JPG?options=399,q85",
                Description = "Fresh from a can! Yum yum."
            };
            MenuItem item2 = new MenuItem
            {
                Id = Guid.NewGuid(),
                Name = "Biefstuk",
                Type = "Main-Course",
                Ingredients = new List<Ingredient> {new Ingredient{Id = new Guid("1b6c3120-d838-4d39-8267-98ce99d829e3"), Name = "Meat"}, new Ingredient{Id = new Guid("00e40ead-fd99-420b-8362-2fa3bfefac6c"), Name = "Sauce"}},
                Price = 67.15,
                Image = "https://static.ah.nl/static/recepten/img_062491_890x594_JPG.jpg",
                Description = "Dead cow, very yummy."
            };
            MenuItem item3 = new MenuItem
            {
                Id = Guid.NewGuid(),
                Name = "Creme Brulee",
                Type = "Na",
                Ingredients = new List<Ingredient> {new Ingredient{Id = new Guid("57dea44c-f989-4c30-a2b7-60ecd9946fcd"), Name = "Sugar"}, new Ingredient{Id = new Guid("cdd0375c-081b-45eb-a105-194ccc2540ba"), Name = "Custard type beat"}},
                Price = 100.15,
                Image = "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/77384360-B5BC-4737-805E-C83023F3F281/Derivates/10B65431-A7A2-4182-831E-C0228FFD3EA7.jpg",
                Description = "Delicious sugar set aflame and caramalised."
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