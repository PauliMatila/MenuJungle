using System;
using System.Collections.Generic;
using System.Text;

namespace MenuJungleLibrary
{
    public class Menu
    {
        public Menu()
        {
            Appetizers = new List<Dish>();
            MainDishes = new List<Dish>();
            Desserts = new List<Dish>();
        }

        public List<Dish> Appetizers { get; set; }
        public List<Dish> MainDishes { get; set; }
        public List<Dish> Desserts { get; set; }
        public string Name { get; set; }

        //private List<Dish> appetizers = new List<Dish>();

        //public List<Dish> Appetizers
        //{
        //    set { appetizers = value; }
        //    get { return appetizers; }
        //}
    }  
}
