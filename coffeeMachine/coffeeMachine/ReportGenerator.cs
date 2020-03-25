using System;
using System.Collections.Generic;
using System.Linq;

namespace coffeeMachine
/*
             * 1. create new object of report generator (this will be a class you will make)
             * 2. get list of orders from ordermachine.
             * 3. Pass list of orders to report generator.
             * 4. Report generator will return new instance of the report class with report details populated
             * 5. Console.Write the resulting report. 
             */
{
    public class ReportGenerator
    {


        public string PrintAllDrinks(List<Drink> DrinkList)
        {
            //   Console.WriteLine("The orders so far are:");
            var returnString = string.Empty;
            foreach (Drink drink in DrinkList)
            {
                returnString += drink.DrinkType.ToString() + Environment.NewLine;
            }
            
            return returnString;
        }

        

        public decimal PrintDrinksTotalPrice(List<Drink> drinks)
        {
            return drinks.Sum(drink => drink.Price);
        }

        public int PrintDrinksTotalOrder(List<Drink> drinks)
        {
            return drinks.Count();
        }

        public int PrintCoffeeTotal(List<Drink> drinks)
        {
            foreach (Drink drink in drinks)
            {
                if (drink.DrinkType == DrinkType.Coffee)
                {
                    return drinks.Count();
                }
            }

            return 0;
        }

        public decimal PrintCoffeeTotalPrice(List<Drink> drinks)
        {
            foreach (Drink drink in drinks)
            {
                if (drink.DrinkType == DrinkType.Coffee)
                {
                    return drinks.Sum(drink => drink.Price);
                }
            }

            return 0;
        }
    }
}