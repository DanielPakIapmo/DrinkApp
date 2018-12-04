using DrinkApp.ClassLibrary;
using DrinkApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkApp.Extensions
{
    public static class DrinkExtensions
    {
        public static string DrinkTemperatureQuestion(this IDrink drink)
        {
            string drinkTemperature = null;
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Would you like it hot or cold?");
                drinkTemperature = Console.ReadLine();
                if (Array.IndexOf(ArrayOption.Temperatures, drinkTemperature.ToLower().Trim()) >= 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That is not a temperature we carry, please try again.");
                }
            }
            return drinkTemperature;
        }

        public static bool DrinkSugarQuestion(this IDrink drink)
        {
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Would you like sugar?");
                string response = Console.ReadLine();
                if (response == "yes".ToLower().Trim())
                {
                    return true;
                }
                else if (response == "no".ToLower().Trim())
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("That is not a valid option");
                }
            }
            return false;

        }

        public static bool DrinkCreamQuestion(this IDrink drink)
        {
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Would you like cream?");
                string response = Console.ReadLine();
                if (response == "yes".ToLower().Trim())
                {
                    return true;
                }
                else if (response == "no".ToLower().Trim())
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("That is not a valid option");
                }
            }
            return false;

        }

        public static int DrinkOptionAmountQuestion(this IDrink drink)
        {
            bool isValid = false;
            int amount = 1;
            while (!isValid)
            {
                Console.WriteLine("How many? (minimum 1, only whole numbers)");
                if (Int32.TryParse(Console.ReadLine(), out amount))
                {
                    if (amount > 0)
                    {
                        isValid = true;
                        return amount;
                    }
                }
            }
            return amount;
        }

    }
}
