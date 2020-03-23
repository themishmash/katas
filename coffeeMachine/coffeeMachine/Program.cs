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
            var reportgenerator = new ReportGenerator();

            while (true)
            {

                //TODO if they enter R instead of number, a report with the list of drinks will be generated 

                Console.WriteLine("What drink do you want?");
                Console.WriteLine("1. Coffee");
                Console.WriteLine("2. Tea");
                Console.WriteLine("3. Chocolate");
                Console.WriteLine("4. Orange Juice");
                Console.WriteLine("5. Reports");
               
                string drinkInput = Console.ReadLine();
             

                int drinkSelection;
                if (!Int32.TryParse(drinkInput, out drinkSelection))
                {
                    Console.WriteLine("Please enter a number");
                }

                DrinkType drinkType = (DrinkType)(drinkSelection) - 1;

                if (drinkSelection != 5)
                {
                    //giving properties to new object
                    var order = ordermachine.StartOrder(drinkType);
                    //var reportMessage = reportgenerator.MakeReport(report);

               
                
                    if (order.Drink.CanHaveSugar)
                    {
                        Console.WriteLine("How many sugars would you like?");
                        string sugarInput = Console.ReadLine();

                        int sugarInt = 0;
                        if (Int32.TryParse(sugarInput, out sugarInt))
                        {
                            ordermachine.AddSugar(order, sugarInt);
                            order.AddSugar(sugarInt); //this is the same as above
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

                    decimal moneyDecimal;
                    if (decimal.TryParse(moneyInput, out moneyDecimal))
                    {
                        ordermachine.CustomerPays(order, moneyDecimal);
                    }

                    
                    PrintMessage(order);
                    
                    
                    
                    //Console.WriteLine("______________________________");
                }

                
                if (drinkSelection == 5)
                {
                   
                    
                    PrintReport(reportgenerator, ordermachine);
                    
                    
                }

               

            }
        }


        private static void PrintMessage (Order order)
        {
            Console.Write(PrintDrinkLetter(order.Drink.DrinkType));
            Console.Write($"{PrintExtraHotLetter(order.IsExtraHot)}:");
            Console.Write($"{PrintSugar(order.SugarLevel)}");
            Console.WriteLine(PrintBalanceMsg(order.Drink.Price, order.AmountPaid));

            

        }
    
        

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
            return extraHot ? "h" :string.Empty;

        }

       

        private static string PrintSugar(int sugarLevel) //change to Get instead of print
        {
            return sugarLevel > 0 ? ($"{sugarLevel.ToString()}:0") : "::";

        }

        private static string PrintBalanceMsg(decimal price, decimal money)
        {
            return (money - price) < 0 ? ($":You need to pay another {System.Math.Abs(money - price)} Euros") : string.Empty;
        }

        // private static void PrintReport(OrderMachine ordermachine)
        private static void PrintReport(ReportGenerator reportgenerator, OrderMachine ordermachine)
        {
            /*
             * 1. create new object of report generator (this will be a class you will make)
             * 2. get list of orders from ordermachine.
             * 3. Pass list of orders to report generator.
             * 4. Report generator will return new instance of the report class with report details populated
             * 5. Console.Write the resulting report. 
             */

            Console.WriteLine("This is your report");

            Console.WriteLine($"The drinks so far are: {reportgenerator.PrintAllDrinks(ordermachine.DrinkList)}");
            
            Console.WriteLine($"Total Price: {reportgenerator.PrintDrinksTotalPrice(ordermachine.DrinkList)}");

            Console.WriteLine($"Total orders: {reportgenerator.PrintDrinksTotalOrder(ordermachine.DrinkList)}");
            
        }


        


            

        }
}
