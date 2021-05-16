using System;
using System.Collections.Generic;

namespace MenuApp.MenuService.Logic.Entities
{
    public class MenuItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}