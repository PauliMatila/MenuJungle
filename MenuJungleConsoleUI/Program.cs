using MenuJungleLibrary;
using System;
using System.Collections.Generic;

namespace MenuJungleConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
        List<Dish> dishes = new List<Dish>();
        List<Menu> menus = new List<Menu>();

        dishes.Add(new Dish("Kanakeitto", "Kanaa ja keittoa", 12.50, 1));
        menus.Add(new Menu("Salaatti", "Pyttipannu", "jäätelö", "ranskalaiset"));
            //Testi annos ja testi ruokalista
        }
        public Dish CreateDish()
        {
            Console.WriteLine("Syötä ruuan nimi:");
            string aName = Console.ReadLine();
            Console.WriteLine("Syötä ruuan sisältö:");
            string aDescription = Console.ReadLine();
            Console.WriteLine("Syötä ruuan hinta:");
            double aPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Syötä ruuan listanumero:");
            int aDishid = Convert.ToInt32(Console.ReadLine());

            Dish dishes = new Dish(aName, aDescription, aPrice, aDishid);

            return dishes;
        }
    }
}
