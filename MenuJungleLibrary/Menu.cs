using System;
using System.Collections.Generic;
using System.Text;

namespace MenuJungleLibrary
{
    public class Menu
    {
        public string Appetizers { get; set; }
        public string MainCourse { get; set; }
        public string Dessert { get; set; }
        public string SideDishes { get; set; }

        public Menu(string aAppetizers, string aMaincourse, string aDessert, string aSidedishes)
        {
            this.Appetizers = aAppetizers;
            this.MainCourse = aMaincourse;
            this.Dessert = aDessert;
            this.SideDishes = aSidedishes;
        }
    }
}
