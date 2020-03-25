using System;
using System.Collections.Generic;
using System.Text;

namespace MenuJungleLibrary
{
    class MainMenu
    {
        public MainMenu()
        {

        }
        public DataHandler dataHandler;

        public MainMenu(DataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }

        public void OpenMainMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ShowMainMenu();
            }
        }

        public bool ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Lisää annos:");
            Console.WriteLine("2. Näytä annos lista:");
            int selected = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (selected)
            {
                case 1:
                    dataHandler.AddDishToList();
                    break;
                case 2:
                    dataHandler.PrintDishList();
                    break;
                default:
                    Console.Clear();
                    return true;
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();
            return true;
        }
    }
}
