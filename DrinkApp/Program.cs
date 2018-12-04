using DrinkApp.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DrinkApp.Methods.DrinkOrderMethods;
using static DrinkApp.Methods.PrintScreenMethods;
using System.Threading.Tasks;
using DrinkApp.Extensions;

namespace DrinkApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool IsCustomerStillOrdering = true;
            bool CustomerWantsToMakeAnotherOrder = true;
            List<Drink> drinkOrder;
            decimal total;
            //First do while to make finish up the entire order and if there needs to be another order, we can loop again
            do
            {
                //Initialize
                Introduction();
                drinkOrder = new List<Drink>();
                total = 0.00M;

                //This do while is to ensure they order a drink that is contained in the array of drinks - and if they finish their order, they will come out of this loop
                do
                {
                    string drink = Console.ReadLine();
                    switch (drink.ToLower())
                    {
                        case "juice":
                            Juice juice = new Juice();
                            DrinkSizeQuestion(juice);
                            JuiceFlavorQuestion(juice);
                            total = DrinkConfirmationQuestion(juice, drinkOrder, total);
                            break;
                        case "tea":
                            Tea tea = new Tea();
                            DrinkSizeQuestion(tea);
                            tea.Temperature = tea.DrinkTemperatureQuestion();
                            tea.Sugar = tea.DrinkSugarQuestion();
                            if (tea.Sugar)
                            {
                                tea.AmountofSugar = tea.DrinkOptionAmountQuestion();
                            }
                            total = DrinkConfirmationQuestion(tea, drinkOrder, total);
                            break;
                        case "coffee":
                            Coffee coffee = new Coffee();
                            DrinkSizeQuestion(coffee);
                            coffee.Temperature = coffee.DrinkTemperatureQuestion();
                            coffee.Sugar = coffee.DrinkSugarQuestion();
                            if (coffee.Sugar)
                            {
                                coffee.AmountofSugar = coffee.DrinkOptionAmountQuestion();
                            }
                            coffee.Cream = coffee.DrinkCreamQuestion();
                            if (coffee.Cream)
                            {
                                coffee.AmountofCream = coffee.DrinkOptionAmountQuestion();
                            }
                            total = DrinkConfirmationQuestion(coffee, drinkOrder, total);
                            break;
                        case "checkout":
                            if (drinkOrder.Count > 0)
                            {
                                IsCustomerStillOrdering = false;
                            }
                            else
                            {
                                Console.WriteLine("You cannot checkout with 0 items.");
                            }
                            break;
                        default:
                            Console.WriteLine("That is not a type of drink we serve. Please try again");
                            Console.WriteLine("------------------------------------------------------------------------------------------------");

                            break;
                    }
                    if (IsCustomerStillOrdering)
                    {
                        Console.Clear();
                        ContinueOrderScreen(total);
                    }
                }
                while (IsCustomerStillOrdering);
                OrderSummary(drinkOrder);
                CustomerWantsToMakeAnotherOrder = OrderComplete(total);


            }
            while (CustomerWantsToMakeAnotherOrder);

        }
    }
}