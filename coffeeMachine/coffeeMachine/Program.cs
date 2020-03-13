using System;
//using System.Net;
//using coffeeMachine;
using System.Collections.Generic;

namespace coffeeMachine
{
    partial class Program
    {
        

        static void Main(string[] args)
        {


            //Checking that making drinks works! It does
            //Drinkmaker tea = new Drinkmaker(
            //    "T",
            //    2);

            //Console.WriteLine($"{tea.drink}:{tea.sugar}:");

            //tea.GetDetails();

            //var drinkmaker = new DrinkMaker();
            //var order = drinkmaker.PlaceOrder(DrinkType.Tea, 3);

            //Console.WriteLine(order.DrinkType + ":" +order.Sugar +"hello"+order.Stick);
            //Console.WriteLine(($"You order {order.DrinkType} with sugar level {order.Sugar}"));
            processDrinks();


            //This refers to function below
            //Console.WriteLine(GetDrink(order));
        }

        public static void processDrinks()

        {
            //Initialize new OrderMachine object. This has to be outside of the while loop otherwise it will keep resetting the cost and number of drinks to 0.
            //so only one ordermachine 
            var ordermachine = new OrderMachine();

            while (true)
            {


                Console.WriteLine("What drink do you want?");
                Console.WriteLine("1. Coffee");
                Console.WriteLine("2. Tea");
                Console.WriteLine("3. Chocolate");
                Console.WriteLine("4. Orange Juice");
                string drinkInput = Console.ReadLine();

                int drinkSelection;
                if (!Int32.TryParse(drinkInput, out drinkSelection))
                {
                    Console.WriteLine("Please enter a number");
                }

                //Only ask sugars and if want extra hot if it is c, t, hc
                int sugarInt = 0;
                string tempInput = string.Empty;
                if (drinkSelection != 4)
                {
                    Console.WriteLine("How many sugars would you like?");
                    string sugarInput = Console.ReadLine();


                    if (!Int32.TryParse(sugarInput, out sugarInt))
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    //Only asks about extra hot if it is c, t, hc
                    Console.WriteLine("Would you like it to be extra hot? Y/N");
                    tempInput = Console.ReadLine().ToUpper();

                }



 
                //say drinktype
                DrinkType drinkType = (DrinkType)(drinkSelection) - 1;
                

                //giving properties to new object
                var order = ordermachine.PlaceOrder(drinkType, sugarInt, tempInput);


                Console.WriteLine($"That will be {order.Price}");
                Console.WriteLine("How much money do you have?");
                string moneyInput = Console.ReadLine();

                decimal moneyAmount;
                if (!decimal.TryParse(moneyInput, out moneyAmount))
                {
                    Console.WriteLine("Please enter a number");
                }

                //This prints out the price of the drink
                //Console.WriteLine($"The total cost for {drinkType} is {order.Price} Euros"); //0.6


                var balance = ordermachine.GetBalance(order.Price, moneyAmount);
                //var message = GetDrinkMessage(order, balance);

                var report = ordermachine.GetReports();
                foreach(var eachDrink in report)
                {
                    Console.WriteLine($"Total {eachDrink.Key} order : {eachDrink.Value.TotalOrder}");
                    Console.WriteLine($"Total {eachDrink.Key} transaction : {eachDrink.Value.TotalCost}");
                    Console.WriteLine($"Total {eachDrink.Key} stock level : {eachDrink.Value.TotalStock}");
                }

                //All drinks sold:

                Console.WriteLine($"Total orders: {ordermachine.GetTotalTransactions().TotalOrder}");
                Console.WriteLine($"Total cost: {ordermachine.GetTotalTransactions().TotalCost}");



                //Console.WriteLine(message);





                Console.WriteLine($"The change is {balance}");


                Console.WriteLine("______________________________");

            }
        }



    

    }
}
