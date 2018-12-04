using DrinkApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DrinkApp.Methods.DrinkOrderMethods;

namespace DrinkApp.ClassLibrary
{
    public class Tea : Drink, IDrink
    {
        public Tea()
        {
            Name = "tea";
            Cost = 2.00M;
        }
        public string Temperature { get; set; }
        public bool Sugar { get; set; }
        public int AmountofSugar { get; set; }
        public override void PrintDrinkSummary()
        {
            if (Sugar)
            {
                DrinkSummary = String.Concat(Temperature, " ", Name.ToLower(), " with ", AmountofSugar, " sugar packets");
                Console.WriteLine(DrinkSummary);
            }
            else
            {
                DrinkSummary = String.Concat(Temperature, " ", Name.ToLower(), " with no sugar");
                Console.WriteLine(DrinkSummary);
            }
        }



    }
}
