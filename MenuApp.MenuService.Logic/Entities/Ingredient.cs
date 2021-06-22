using System;

namespace MenuApp.MenuService.Logic.Entities
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Optional { get; set; }
    }
}