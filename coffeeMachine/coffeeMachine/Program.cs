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

                //say which drinktype
                DrinkType drinkType = (DrinkType)(drinkSelection) - 1;

                //giving properties to new object
                var order = ordermachine.StartOrder(drinkType);

                //Only ask sugars and if want extra hot if it is c, t, hc
               
                
                if (order.Drink.CanHaveSugar)
                {
                    Console.WriteLine("How many sugars would you like?");
                    string sugarInput = Console.ReadLine();

                    int sugarInt = 0;
                    if (Int32.TryParse(sugarInput, out sugarInt))
                    {
                        ordermachine.AddSugar(order, sugarInt);
                    }
                }


                ////Only asks about extra hot if it is c, t, hc
                if (order.Drink.CanBeExtraHot)
                {
                   
                    Console.WriteLine("Would you like it to be extra hot? Y/N");
                    string yesOrNo = Console.ReadLine().ToUpper();

                    if (yesOrNo == "Y")
                    {
                        ordermachine.ExtraHot(order, true);
                    }
                   
                }



                Console.WriteLine($"That will be {order.Drink.Price}");
                Console.WriteLine("How much money do you have?");
                string moneyInput = Console.ReadLine();

                decimal moneyAmount;
                if (decimal.TryParse(moneyInput, out moneyAmount))
                {
                    ordermachine.GetBalance(order.Drink.Price, moneyAmount);
                }


                //var balance = ordermachine.GetBalance(order.Price, moneyAmount);
                ////var message = GetDrinkMessage(order, balance);

                //var report = ordermachine.GetReports();
                //foreach(var eachDrink in report)
                //{
                //    Console.WriteLine($"Total {eachDrink.Key} order : {eachDrink.Value.TotalOrder}");
                //    Console.WriteLine($"Total {eachDrink.Key} transaction : {eachDrink.Value.TotalCost}");
                //    Console.WriteLine($"Total {eachDrink.Key} stock level : {eachDrink.Value.TotalStock}");
                //}

                ////All drinks sold:

                //Console.WriteLine($"Total orders: {ordermachine.GetTotalTransactions().TotalOrder}");
                //Console.WriteLine($"Total cost: {ordermachine.GetTotalTransactions().TotalCost}");


                //Console.WriteLine(message);

                PrintMessage(order);
               //PrintMessage(order); //why is this only work for order?

                //Console.WriteLine($"The change for the customer is {balance}");

   


                //Console.WriteLine("______________________________");

            }
        }


        private static void PrintMessage (Order order)
        {
            Console.Write(PrintDrinkLetter(order.Drink.DrinkType));
            Console.Write(PrintExtraHotLetter(order.IsExtraHot));
            Console.WriteLine(PrintSugar(order.SugarLevel));
            Console.WriteLine(PrintBalanceMsg(order.AmountPaid));

            
            //Console.WriteLine(order.NeedsStick());

        }
        //{PrintSugar(order.SugarLevel)}
        

    private static string PrintDrinkLetter(DrinkType drinkType)
        {         
            switch (drinkType)
            {
                case DrinkType.Tea:
                    return "T";
                   
                case DrinkType.Coffee:
                    return "C";
                    
                case DrinkType.HotChoc:
                   return "H";
                    
                case DrinkType.Orange:
                    return "O";

                default:
                    return string.Empty;

            }
           
        }


        private static string PrintExtraHotLetter(bool extraHot)
        {
            return extraHot ? "h" : string.Empty;

        }

        //private static string PrintExtraHotLetter(Order order)
        //{
        //    return order.Drink.CanBeExtraHot && order.IsExtraHot ? "h" : string.Empty;

        //}



        private static string PrintSugar(int sugarLevel)
        {
            return sugarLevel > 0 ? ($" :{ sugarLevel.ToString()}:0") : "::";

        }

        private static string PrintBalanceMsg(decimal getBalance)
        {
            return getBalance < 0 ? ($":You need to pay another {System.Math.Abs(getBalance)} + Euros") : string.Empty;
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
