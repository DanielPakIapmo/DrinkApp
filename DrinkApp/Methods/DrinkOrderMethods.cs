using DrinkApp.ClassLibrary;
using DrinkApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkApp.Methods
{
    public static class DrinkOrderMethods
    {
        public static void DrinkSizeQuestion(Drink drink)
        {
            bool isValid = false;
            Console.WriteLine("What size would you like? (small/medium/large)");
            while (!isValid)
            {
                string drinkSize = Console.ReadLine();
                if (Array.IndexOf(ArrayOption.SizeOptions, drinkSize.ToLower().Trim()) >= 0)
                {
                    drink.Size = drinkSize;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That is not a size we have, please try again.");
                }
            }
        }

        public static void JuiceFlavorQuestion(Juice juice)
        {
            bool isValid = false;
            Console.WriteLine("Which flavor would you like? (Apple, Mango, Orange)");
            while (!isValid)
            {
                string juiceFlavor = Console.ReadLine();
                if (Array.IndexOf(ArrayOption.JuiceFlavors, juiceFlavor.ToLower().Trim()) >= 0)
                {
                    juice.Flavor = juiceFlavor;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That is not a flavor we carry, please try again.");
                }
            }
        }

        public static decimal DrinkConfirmationQuestion(Drink drink, List<Drink> drinks, decimal total)
        {
            bool isValid = false;
            Console.WriteLine("Does this order appear correctly on the screen? (yes/no)");
            drink.PrintDrinkSummary();
            while (!isValid)
            {
                string answerConfirmation = Console.ReadLine();
                if (answerConfirmation.ToLower().Trim() == "yes")
                {
                    isValid = true;
                    drinks.Add(drink);
                    total = total + drink.Cost;
                }
                else if (answerConfirmation.ToLower().Trim() == "no")
                {
                    isValid = true;
                    Console.Clear();
                    Console.WriteLine("Sorry about that, please start your order again.");
                }
                else
                {
                    Console.WriteLine("That is not a valid option");
                }
            }
            return total;

        }





    }
}
