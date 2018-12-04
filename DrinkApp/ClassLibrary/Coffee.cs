using DrinkApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DrinkApp.Methods.DrinkOrderMethods;

namespace DrinkApp.ClassLibrary
{
    public class Coffee : Drink, IDrink
    {
        public Coffee()
        {
            Name = "coffee";
            Cost = 3.00M;
        }

        public string Temperature { get; set; }
        public bool Cream { get; set; }
        public int AmountofCream { get; set; }
        public bool Sugar { get; set; }
        public int AmountofSugar { get; set; }
        public override void PrintDrinkSummary()
        {
            if (Sugar && Cream)
            {
                DrinkSummary = String.Concat(Temperature, " ", Name.ToLower(), " with ", AmountofSugar, " sugar packets and ", AmountofCream, " creamers");
                Console.WriteLine(DrinkSummary);
            }
            else if (Sugar && !Cream)
            {
                DrinkSummary = String.Concat(Temperature, " ", Name.ToLower(), " with ", AmountofSugar, " sugar packets and no cream");
                Console.WriteLine(DrinkSummary);

            }
            else if (!Sugar && Cream)
            {
                DrinkSummary = String.Concat(Temperature, " ", Name.ToLower(), " with ", AmountofCream, " creamers and no sugar");
                Console.WriteLine(DrinkSummary);
            }
            else
            {
                DrinkSummary = String.Concat(Temperature, " ", Name.ToLower(), " with no sugar and no cream");
                Console.WriteLine(DrinkSummary);
            }

        }


    }
}
