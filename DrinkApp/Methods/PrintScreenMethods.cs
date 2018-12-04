using DrinkApp.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkApp.Methods
{
    public static class PrintScreenMethods
    {
        public static void Introduction()
        {
            Console.WriteLine("Welcome to the Drink App.");
            Console.WriteLine("What would you like to drink?");
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine(@"-------------- Menu --------------
Juice: $1.00
Tea: $2.00
Coffee: $3.00
When you are completed with your order, please type checkout and your order summary will appear.");

        }

        public static void OrderSummary(List<Drink> drinks)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Thank you for submitting your order. The items you have purchased will be shown below with a total");
            StringBuilder orderSummary = new StringBuilder();
            foreach (Drink d in drinks)
            {
                if (d is Juice juice)
                {
                    orderSummary.Append(juice.DrinkSummary);
                }
                if (d is Tea tea)
                {
                    orderSummary.Append(tea.DrinkSummary);
                }
                if (d is Coffee coffee)
                {
                    orderSummary.Append(coffee.DrinkSummary);
                }
                if (!d.Equals(drinks.Last()))
                {
                    orderSummary.Append(", ");
                }
            }
            Console.WriteLine(orderSummary);

        }

        public static void ContinueOrderScreen(decimal total)
        {
            Console.WriteLine("Your current total is ${0}", total);
            Console.WriteLine("You may place more orders or enter 'checkout' to close out your order");
            Menu();

        }

        public static bool OrderComplete(decimal total)
        {
            Console.WriteLine(String.Concat("Total: $", total));
            Console.WriteLine("Please send the amount in the current price of BTC to tSLRHtKNngkdXEeobR76b53LETtpyT");
            Console.WriteLine("If you want to create another order, press any key or press ESC to close");

            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
                return false;
            }
            Console.Clear();
            return true;

        }
    }
}
