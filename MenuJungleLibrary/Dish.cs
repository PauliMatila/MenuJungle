using System;
using System.Collections.Generic;
using System.Text;

namespace MenuJungleLibrary
{
    public class Dish
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        //public int DishID { get; set; }

        public Dish(string aName, string aDescription, double aPrice)
        {
            Name = aName;
            Description = aDescription;
            Price = aPrice;
            //DishID = aDishid;
        }
    }
}
