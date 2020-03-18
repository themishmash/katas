

//TO DO
// set properties of drinks - drink type, sugar, message
// create constructor
//create method where if sugar - add stick else no stick
//message 

using System;
using System.Collections.Generic;
using System.Linq;

//this class processes the order. This shows to the user - the actual request

namespace coffeeMachine
{

    public class OrderMachine
    {


        //Dictionary that is connected to Report class - see Report class
        private Dictionary<DrinkType, Report> _report = new Dictionary<DrinkType, Report>();


        //constructor
        public OrderMachine()
        {
            foreach (DrinkType drinkType in Enum.GetValues(typeof(DrinkType)))
                {
                _report.Add(drinkType, new Report() { TotalOrder = 0, TotalCost = 0, TotalStock = 10 });
            };



        }




        //Constructor. In the constructor - calling DrinkType from DrinkType File)
        //can have more logic later on by putting this PlaceOrder method here

        public Order StartOrder(DrinkType drinkType)
        {
            
            //_totalCost += price;

            
            Drink drink = null;
            //instantiate drink first

            

            //this one fixed - removed the previous things that were passed as arguments for new instances
            switch (drinkType)
            {
                case DrinkType.Coffee:
                    drink = new Coffee();
                    break;
                //can return for any case - if not coffee. don't need this if have all the drinks.

                case DrinkType.Tea:
                    drink = new Tea();
                    break;
                case DrinkType.HotChoc:
                    drink = new HotChoc();
                    break;
                case DrinkType.Orange:
                    drink = new Orange();
                    break;

            }

            var order = SaveOrder(drink);

           
            return order;
           
            //return new Drink(drinktype, sugar, temp, message, price);
        }


        public void AddSugar(Order order, int sugar)
        {
            order.SugarLevel = sugar;
        }

        public void ExtraHot (Order order, bool extraHot)
        {
            order.IsExtraHot = extraHot;
        }


        public decimal GetBalance(decimal price, decimal money)
        {
            return money - price;
        }

      

        //every time order drink, want to increment order and cost in the dictionary
        private Order SaveOrder(Drink drink)
        {

            var order = new Order();
            order.Drink = drink;


            return order;
          

        }

        public Report GetTotalTransactions()
        {
            var Report = new Report();
            foreach (var eachDrink in _report.Keys)
            {
                Report.TotalCost += _report[eachDrink].TotalCost;
                Report.TotalOrder += _report[eachDrink].TotalOrder;
                Report.TotalStock += _report[eachDrink].TotalStock;
                //Added this too
                //Report.TotalCoffee--;
               
            }

            return Report;
        }


      

      
        // This is returning the value of the Report class of the particular drinktype

            //this only returned particular drink
        public Report GetReport(DrinkType drinkType)
        {
            return _report[drinkType];
        }

        //This can return everything
        public Dictionary<DrinkType, Report> GetReports()
        {
            return _report;
        }




        private bool IsExtraHot(string input)
        {
            return input.ToUpper() == "Y";
        }

        


    }


}


//public interface IA
//{
//    void SaveOrder();
//    int GetOrder();
//}

//public class A : IA
//{
//    public void SaveOrder()
//    {
//        //
//    }

//    public int GetOrder()
//    {
//        return 0;
//    }
//}