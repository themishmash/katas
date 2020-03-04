﻿using System;
//using System.Net;
//using coffeeMachine;
//using System.Collections.Generic;

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

            //Only ask sugars if it is c, t, hc
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
                tempInput = Console.ReadLine();
            }


            

            

            const decimal CoffeePrice = 0.6M;
            const decimal TeaPrice = 0.4M;
            const decimal ChocPrice = 0.5M;
            const decimal OrangePrice = 0.6M;

            //Initialize new OrderMachine object
            var ordermachine = new OrderMachine();

            //say drinktype
            DrinkType drinktype = (DrinkType)(drinkSelection) - 1;
            var price = 0M;
            switch(drinktype)
            {
                case DrinkType.Coffee:
                    price = CoffeePrice;
                    break;

                case DrinkType.Tea:
                    price = TeaPrice;
                    break;

                case DrinkType.HotChoc:
                    price = ChocPrice;
                    break;

                case DrinkType.Orange:
                    price = OrangePrice;
                    break;
                //default:
                //    break;
            }

            //giving properties to new object
            var order = ordermachine.PlaceOrder(drinktype, sugarInt, tempInput, "", price);


            Console.WriteLine("How much money do you have?");
            string moneyInput = Console.ReadLine();

            decimal moneyAmount;
            if (!decimal.TryParse(moneyInput, out moneyAmount))
            {
                Console.WriteLine("Please enter a number");
            }

            //This prints out the price of the drink
            Console.WriteLine($"The total cost for {drinktype} is {order.Price}"); //0.6

       
            var balance = ordermachine.GetBalance(order.Price, moneyAmount);
            var message = GetDrinkMessage(order, balance);


            Console.WriteLine(message);

        }


    //not using this method - using the GetDrinkMessage one instead

        private static string GetDrink(Drink order)
        {
            //Allows sugar to return nothing
            var sugarOutput = order.Sugar > 0 ? order.Sugar.ToString() : string.Empty;

            string drinktype = string.Empty; //need to assign / initialize first the variable otherwise error

            

            switch (order.DrinkType)
            {
                case DrinkType.Tea:
                    drinktype = "T";
                    break;
                case DrinkType.Coffee:
                    drinktype = "C";
                    break;
                case DrinkType.HotChoc:
                    drinktype = "H";
                    break;
                    
            }
            //if testing - woudl do it to the the string itself
            return ($"{drinktype}:{sugarOutput}:{order.Stick}");
        }


        
        private static string GetDrinkMessage (Drink order, decimal balance)
        {

            var sugarOutput = order.Sugar > 0 ? order.Sugar.ToString() : string.Empty;

            var tempOutput = order.Temp == "Y" ? "h" : string.Empty;

            string drinktype = string.Empty; //need to assign / initialize first the variable otherwise error

            //string msgNotEnough = "Not enough money here";
            

            switch (order.DrinkType)
            {
                case DrinkType.Tea:
                    drinktype = "T";
                    break;
                case DrinkType.Coffee:
                    drinktype = "C";
                    break;
                case DrinkType.HotChoc:
                    drinktype = "H";
                    break;
                case DrinkType.Orange:
                    drinktype = "O";
                    break;

            }

            var msg = string.Empty;
            if (balance < 0)
                msg = "you need to pay another " + System.Math.Abs(balance) + " Euros";

            return ($"{drinktype}{tempOutput}:{sugarOutput}:{order.Stick}:{msg}");

        }

        
    }
}
