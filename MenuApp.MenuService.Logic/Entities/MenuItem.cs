using System;
using System.Collections.Generic;

namespace MenuApp.MenuService.Logic.Entities
{
    public class MenuItem
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public List<Guid> Ingredients { get; set; }
        public Double Price { get; set; }
    }
}