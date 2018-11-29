using DrinkApp.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool IsCustomerStillOrdering = true;
            do
            {
                Console.WriteLine("Welcome to the Drink App. You may restart your order with the ESC key.");
                Console.WriteLine("What would you like to drink?");
                Console.WriteLine(@"-------------- Menu --------------
Juice: $1.00
Tea: $2.00
Coffee: $3.00
When you are completed with your order, please type checkout and your order summary will appear.");
                List<Drink> drinkOrder = new List<Drink>();
                decimal total = 0.00M;
                bool IsCustomerStillAddingDrinks = true;
                do
                {
                    string drink = Console.ReadLine();
                    switch (drink.ToLower())
                    {
                        case "juice":
                            Juice juice = new Juice();
                            Console.WriteLine("What size would you like? (small/medium/large)");
                            juice.Size = Console.ReadLine();
                            Console.WriteLine("Which flavor would you like? (Apple, Mango, Orange)");
                            juice.Flavor = Console.ReadLine();
                            Console.WriteLine("Does this order appear correctly on the screen? (yes/no)");
                            juice.DrinkSummary = String.Concat(juice.Size, " ", juice.Flavor, " ", juice.Name.ToLower());
                            Console.WriteLine(juice.DrinkSummary);
                            if (Console.ReadLine() == "yes".ToLower())
                            {
                                total = total + juice.Cost;
                                drinkOrder.Add(juice);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sorry about that, lets start the order over");
                            }
                            break;
                        case "tea":
                            Tea tea = new Tea();
                            Console.WriteLine("What size would you like? (small/medium/large)");
                            tea.Size = Console.ReadLine();
                            Console.WriteLine("Would you like the tea hot or cold?");
                            tea.Temperature = Console.ReadLine();
                            Console.WriteLine("Would you like sugar?");
                            if (Console.ReadLine() == "yes".ToLower())
                            {
                                tea.Sugar = true;
                                Console.WriteLine("How many sugar packets?");
                                tea.AmountofSugar = Console.ReadLine();
                            }

                            Console.WriteLine("Does this order appear correctly on the screen? (yes/no)");
                            if (tea.Sugar)
                            {
                                tea.DrinkSummary = String.Concat(tea.Temperature, " ", tea.Name.ToLower(), " with ", tea.AmountofSugar, " sugar packets");
                                Console.WriteLine(tea.DrinkSummary);
                            }
                            else
                            {
                                tea.DrinkSummary = String.Concat(tea.Temperature, " ", tea.Name.ToLower(), " with no sugar");
                                Console.WriteLine(tea.DrinkSummary);
                            }
                            if (Console.ReadLine() == "yes".ToLower())
                            {
                                total = total + tea.Cost;
                                drinkOrder.Add(tea);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sorry about that, lets start the order over");
                            }
                            break;
                        case "coffee":
                            Coffee coffee = new Coffee();
                            Console.WriteLine("What size would you like? (small/medium/large)");
                            coffee.Size = Console.ReadLine();
                            Console.WriteLine("Would you like the coffee hot or cold?");
                            coffee.Temperature = Console.ReadLine();
                            Console.WriteLine("Would you like sugar?");
                            if (Console.ReadLine() == "yes".ToLower())
                            {
                                coffee.Sugar = true;
                                Console.WriteLine("How many sugar packets?");
                                coffee.AmountofSugar = Console.ReadLine();
                            }
                            Console.WriteLine("Would you like cream?");
                            if (Console.ReadLine() == "yes".ToLower())
                            {
                                coffee.Cream = true;
                                Console.WriteLine("How many creamers?");
                                coffee.AmountofCream = Console.ReadLine();
                            }

                            Console.WriteLine("Does this order appear correctly on the screen? (yes/no)");
                            if (coffee.Sugar && coffee.Cream)
                            {
                                coffee.DrinkSummary = String.Concat(coffee.Temperature, " ", coffee.Name.ToLower(), " with ", coffee.AmountofSugar, " sugar packets and ", coffee.AmountofCream, " creamers");
                                Console.WriteLine(coffee.DrinkSummary);
                            }
                            else if (coffee.Sugar && !coffee.Cream)
                            {
                                coffee.DrinkSummary = String.Concat(coffee.Temperature, " ", coffee.Name.ToLower(), " with ", coffee.AmountofSugar, " sugar packets and no cream");
                                Console.WriteLine(coffee.DrinkSummary);

                            }
                            else if (!coffee.Sugar && coffee.Cream)
                            {
                                coffee.DrinkSummary = String.Concat(coffee.Temperature, " ", coffee.Name.ToLower(), " with ", coffee.AmountofCream, " creamers and no sugar");
                                Console.WriteLine(coffee.DrinkSummary);
                            }
                            else
                            {
                                coffee.DrinkSummary = String.Concat(coffee.Temperature, " ", coffee.Name.ToLower(), " with no sugar and no cream");
                                Console.WriteLine(coffee.DrinkSummary);
                            }
                            if (Console.ReadLine() == "yes".ToLower())
                            {
                                total = total + coffee.Cost;
                                drinkOrder.Add(coffee);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sorry about that, lets start the order over");
                            }
                            break;
                        case "checkout":
                            IsCustomerStillAddingDrinks = false;
                            break;
                        default:
                            Console.WriteLine("That is not a drink we serve. Please try again");
                            break;
                    }
                    if (IsCustomerStillAddingDrinks)
                    {
                        Console.Clear();
                        Console.WriteLine("Your current total is ${0}", total);
                        Console.WriteLine("You may place more orders or enter 'checkout' to close out your order");
                        Console.WriteLine(@"-------------- Menu --------------
Juice: $1.00
Tea: $2.00
Coffee: $3.00");
                    }
                }
                while (IsCustomerStillAddingDrinks);
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Thank you for submitting your order. The items you have purchased will be shown below with a total");
                StringBuilder orderSummary = new StringBuilder();
                foreach (Drink d in drinkOrder)
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
                    if (!d.Equals(drinkOrder.Last()))
                    {
                        orderSummary.Append(", ");
                    }
                }

                Console.WriteLine(orderSummary);
                Console.WriteLine(String.Concat("Total: $", total));
                Console.WriteLine("Thank you for your order. Please send the amount in the current price of BTC to tSLRHtKNngkdXEeobR76b53LETtpyT");
                Console.WriteLine("If you want to create another order, press any key or press ESC to close");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                Console.Clear();
            }
            while (IsCustomerStillOrdering);
        }
    }
}
