using System;
using System.Collections.Generic;
using System.Text;
using static MenuJungleLibrary.Dish;

namespace MenuJungleLibrary
{
    class DataHandler
    {
        public List<Dish> dishes = new List<Dish>();

        public Dish CreateDish()
        {
            Console.WriteLine("syötä annoksen nimi: ");
            string aName = Console.ReadLine();
            Console.WriteLine("syötä annoksen sisältö: ");
            string aDescription = Console.ReadLine();
            Console.WriteLine("syötä annoksen hinta: ");
            double aPrice = double.Parse(Console.ReadLine());

            Dish dish = new Dish(aName, aDescription, aPrice);

            return dish;
        }

        public Dish AddDishToList()
        {
            Dish dish = CreateDish();
            this.dishes.Add(dish);
            Console.WriteLine("Annos lisätty listaan");
            return dish;
        }
       
        public void PrintDishList()
        {
            if (this.dishes.Count == 0)
            {
                Console.WriteLine("Annos lista tyhjä");
            }
            for (int i = 0; i < this.dishes.Count; i++)
            {
                Console.WriteLine($"[i]. {this.dishes[i].Name} {this.dishes[i].Description} {this.dishes[i].Price}");
            }
        }

        public Dish SelectDishFromList()
        {
            PrintDishList();
            Console.WriteLine("Syötä valittavan annoken numero:");
            var selected = int.Parse(Console.ReadLine());
            return this.dishes[selected - 1];
        }
    }
}
