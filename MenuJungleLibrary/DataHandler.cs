using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static MenuJungleLibrary.Dish;

namespace MenuJungleLibrary
{
    public class DataHandler
    {
        public List<Dish> dishes = new List<Dish>();
        public Menu menu = new Menu();

        public void AddTestDishes()
        {
            dishes.Add(new Dish("salaatti", "salaattia, tomaattia, kurkkua", 6.00));
            dishes.Add(new Dish("jauhelihakeitto", "perunaa, jauhelihaa, kasviksia", 10.00));
            dishes.Add(new Dish("mansikkajäätelö", "jäätelöä, mansikkakastiketta", 3.00));
        }

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
            dishes.Add(dish);
            Console.WriteLine("Annos lisätty listaan");
            return dish;
        }

        public void PrintDishList()
        {
            if (dishes.Count == 0)
            {
                Console.WriteLine("Annoslista tyhjä");
                return;
            }
            for (int i = 0; i < this.dishes.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}: {dishes[i].Name.ToUpper()} \n\nsisältö: {dishes[i].Description} \nhinta: {dishes[i].Price.ToString("0.00")}");
            }
        }

        public void AddDishToMenu()
        {
            Console.WriteLine("Valitse lista mihin ruoka lisätään");
            Console.WriteLine("1. alkuruoka");
            Console.WriteLine("2. pääruoka");
            Console.WriteLine("3. jälkiruoka");
            int selected = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (selected)
            {
                case 1:
                    AddAppetizersToMenu();
                    break;
                case 2:
                    AddMainDishesToMenu();
                    break;
                case 3:
                    AddDessertsToMenu();
                    break;
                default:
                    Console.WriteLine("huti män");
                    break;
            }
        }

        public Dish SelectDishFromList()
        {
            PrintDishList();
            Console.WriteLine("\nSyötä valittavan annoksen numero:");
            int selected = int.Parse(Console.ReadLine());
            return dishes[selected - 1];
        }

        public void AddAppetizersToMenu()
        {
            PrintDishList();
            Console.WriteLine("\nSyötä lisättävän alkuruoan numero:");
            int selected = int.Parse(Console.ReadLine());
            this.menu.Appetizers.Add(dishes[selected - 1]);
        }

        public void AddMainDishesToMenu()
        {
            PrintDishList();
            Console.WriteLine("\nSyötä lisättävän pääruoan numero:");
            int selected = int.Parse(Console.ReadLine());
            this.menu.MainDishes.Add(dishes[selected - 1]);
        }

        public void AddDessertsToMenu()
        {
            PrintDishList();
            Console.WriteLine("\nSyötä lisättävän jälkiruoan numero:");
            int selected = int.Parse(Console.ReadLine());
            this.menu.Desserts.Add(dishes[selected - 1]);
        }

        public void ShowMenu()
        {
            Console.WriteLine("ALKUPALAT:");
            if (menu.Appetizers.Count == 0)
            {
                Console.WriteLine("\nEi alkupaloja");
            }
            else
            {
                for (int i = 0; i < menu.Appetizers.Count; i++)
                {
                    Console.WriteLine($"\n{menu.Appetizers[i].Name.ToUpper()}");
                    Console.WriteLine($"sisältö: {menu.Appetizers[i].Description}");
                    Console.WriteLine($"hinta: {menu.Appetizers[i].Price.ToString("0.00")}");
                }
            }
            Console.WriteLine("\nPÄÄRUOKA:");
            if (menu.MainDishes.Count == 0)
            {
                Console.WriteLine("\nEi pääruokia");
            }
            else
            {
                for (int i = 0; i < menu.MainDishes.Count; i++)
                {
                    Console.WriteLine($"\n{menu.MainDishes[i].Name.ToUpper()}");
                    Console.WriteLine($"sisältö: {menu.MainDishes[i].Description}");
                    Console.WriteLine($"hinta: {menu.MainDishes[i].Price.ToString("0.00")}");
                }
            }
            Console.WriteLine("\nJÄLKIRUOKA:");
            if (menu.Desserts.Count == 0)
            {
                Console.WriteLine("\nEi jälkiruokia");
            }
            else
            {
                for (int i = 0; i < menu.Desserts.Count; i++)
                {
                    Console.WriteLine($"\n{menu.Desserts[i].Name.ToUpper()}");
                    Console.WriteLine($"sisältö: {menu.Desserts[i].Description}");
                    Console.WriteLine($"hinta: {menu.Desserts[i].Price.ToString("0.00")}");
                }
            }
        }
    }
}
