using DrinkApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkApp.ClassLibrary
{
    public class Juice : Drink, IDrink
    {
        public Juice()
        {
            Name = "juice";
            Temperature = "cold";
            Cost = 1.00M;

        }
        public string Temperature { get; set; }
        public string Flavor { get; set; }
        public override void PrintDrinkSummary()
        {

            DrinkSummary = String.Concat(Size, " ", Flavor, " ", Name.ToLower());

            Console.WriteLine(DrinkSummary);
        }

    }
}
