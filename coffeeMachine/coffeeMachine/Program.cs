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



                //const decimal CoffeePrice = 0.6M;
                //const decimal TeaPrice = 0.4M;
                //const decimal ChocPrice = 0.5M;
                //const decimal OrangePrice = 0.6M;


                //Don't need it as in the class

                //say drinktype
                DrinkType drinkType = (DrinkType)(drinkSelection) - 1;
                //var price = 0M;
                //switch (drinktype)
                //{
                //    case DrinkType.Coffee:
                //        price = CoffeePrice;
                //        break;

                //    case DrinkType.Tea:
                //        price = TeaPrice;
                //        break;

                //    case DrinkType.HotChoc:
                //        price = ChocPrice;
                //        break;

                //    case DrinkType.Orange:
                //        price = OrangePrice;
                //        break;
                //        //default:
                //        //    break;
                //}

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


                //Console.WriteLine(message);

                Console.WriteLine($"Number of {drinkType} ordered: {ordermachine.GetReport(drinkType).TotalOrder}");
                Console.WriteLine($"Total {drinkType} profit: {ordermachine.GetReport(drinkType).TotalCost}");


                //Console.WriteLine($"Number of Tea ordered: {ordermachine.GetReport(DrinkType.Tea).TotalOrder}");
                
                //Console.WriteLine($"Total Tea profit: {ordermachine.GetReport(DrinkType.Tea).TotalCost}");




                //Console.WriteLine($"Total Tea order: {ordermachine.GetTeaCount()}");
                //Console.WriteLine($"Total Chocolate order: {ordermachine.GetChocCount()}");
                //Console.WriteLine($"Total Orange order: {ordermachine.GetOrangeCount()}");

                //Console.WriteLine($"Coffee stock: {ordermachine.GetCoffeeStock()}");
                //Console.WriteLine($"Tea stock: {ordermachine.GetTeaStock()}");
                //Console.WriteLine($"Chocolate stock: {ordermachine.GetChocStock()}");
                //Console.WriteLine($"Orange stock: {ordermachine.GetOrangeStock()}");

                Console.WriteLine($"Report details for number of drinks: {ordermachine.GetTotalTransactions().TotalOrder}");
                Console.WriteLine($"Report details for total earnings for drinks: {ordermachine.GetTotalTransactions().TotalCost}");

                Console.WriteLine($"Report details for total coffee number: {ordermachine.GetTotalTransactions().TotalCoffee}");




                Console.WriteLine($"The change is {balance}");


                Console.WriteLine("______________________________");

            }
        }


    //not using this method - using the GetDrinkMessage one instead

        
        
        //private static string GetDrinkMessage (Drink order, decimal balance)
        //{

        //    //var sugarOutput = order.SugarLevel > 0 ? order.SugarLevel.ToString() : string.Empty;

        //    //var hotOutput = order.IsExtraHot == "Y" ? "h" : string.Empty;

        //   // string drinktype = string.Empty; //need to assign / initialize first the variable otherwise error

        //    //int coffeeLevel = order.GetCoffeeCount();
        //    //if (coffeeLevel == 0)
        //    //{
        //    //    Console.WriteLine("not enough");
        //    //}

        //    //string msgNotEnough = "Not enough money here";
            

        //    switch (order.DrinkType)
        //    {
        //        case DrinkType.Tea:
        //            drinktype = "T";
        //            break;
        //        case DrinkType.Coffee:
        //            drinktype = "C";
        //            break;
        //        case DrinkType.HotChoc:
        //            drinktype = "H";
        //            break;
        //        case DrinkType.Orange:
        //            drinktype = "O";
        //            break;

        //    }

        //    var msg = string.Empty;
        //    if (balance < 0)
        //        msg = "you need to pay another " + System.Math.Abs(balance) + " Euros";

        //    return ($"{drinktype}{hotOutput}:{sugarOutput}:{order.Stick}:{msg}");

        //}


    

    }
}
