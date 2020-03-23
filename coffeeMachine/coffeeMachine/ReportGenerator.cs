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

        

        public decimal PrintDrinksTotalPrice(List<Drink> DrinkList)
        {
            return DrinkList.Sum(drink => drink.Price);
        }

        public int PrintDrinksTotalOrder(List<Drink> DrinkList)
        {
            return DrinkList.Count();
        }
    }
}