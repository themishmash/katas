using System;
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
            string drinkInput = Console.ReadLine();

            int drinkSelection;
            if (!Int32.TryParse(drinkInput, out drinkSelection))
            {
                Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("How many sugars would you like?");
            string sugarInput = Console.ReadLine();

            int sugarInt;
            if (!Int32.TryParse(sugarInput, out sugarInt))
            {
                Console.WriteLine("Please enter a number!");
            }

            const decimal CoffeePrice = 0.6M;
            const decimal TeaPrice = 0.4M;
            const decimal ChocPrice = 0.5M;
           


            Console.WriteLine("How much money do you have?");
            string moneyInput = Console.ReadLine();

            decimal moneyAmount;
            if (!decimal.TryParse(moneyInput, out moneyAmount))
            {
                Console.WriteLine("Please enter a number");
            }



            var drinkmaker = new OrderMachine();
            DrinkType userOption = (DrinkType)(drinkSelection) - 1;
            var order = drinkmaker.PlaceOrder(userOption, sugarInt, moneyAmount);


            
            if (userOption == DrinkType.Coffee && moneyAmount >= CoffeePrice || userOption == DrinkType.Tea && moneyAmount >= TeaPrice || userOption == DrinkType.HotChoc && moneyAmount >= ChocPrice)
            {
                Console.WriteLine("You have enough money");
                Console.WriteLine(GetDrink(order));
            }
            else
            {
                Console.WriteLine("You don't have enough money");
                Console.WriteLine(GetDrinkMessage(order));

            }


        }



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

        private static string GetDrinkMessage (Drink order)
        {

            var sugarOutput = order.Sugar > 0 ? order.Sugar.ToString() : string.Empty;

            string drinktype = string.Empty; //need to assign / initialize first the variable otherwise error

            string msgNotEnough = "Not enough money here";

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
            return ($"{drinktype}:{sugarOutput}:{order.Stick}:{msgNotEnough}");

        }

        
    }
}
