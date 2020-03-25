using MenuJungleLibrary;
using System;
using System.Collections.Generic;

namespace MenuJungleConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DataHandler dh = new DataHandler();
            MainMenu mainMenu = new MainMenu(dh);
            mainMenu.OpenMainMenu();
            //List<Dish> dishes = new List<Dish>();

            //dishes.Add(new Dish("Kanakeitto", "Kanaa ja keittoa", 12.50));
            //dishes.Add(new Dish("Kaalilaatikko", "Kaalta ja jauhelihaa", 11.00));
            //dishes.Add(new Dish("Jauhelihakeitto", "jauheliha ja kasvikset", 10.00));

            //Menu menu = new Menu();
            //menu.dishes.AddRange(dishes);
            
            //foreach (var item in menu.dishes)
            //{
            //    Console.WriteLine(item.Name);              
            //    Console.WriteLine(item.Description);
            //    Console.WriteLine(item.Price);
            //    Console.WriteLine();
            //}
            //Testi annoksia ruokalistalla
        }
    }
}
