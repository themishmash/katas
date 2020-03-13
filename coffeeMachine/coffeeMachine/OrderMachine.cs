

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



        //starting stock of drinks
        private int _coffeeStock = 10;
        private int _teaStock = 10;
        private int _chocStock = 10;
        private int _orangeStock = 10;

        //Dictionary that is connected to Report class
        private Dictionary<DrinkType, Report> _report = new Dictionary<DrinkType, Report>();

        public OrderMachine()
        {
            foreach (DrinkType drinkType in Enum.GetValues(typeof(DrinkType)))
                {
                _report.Add(drinkType, new Report() { TotalOrder = 0, TotalCost = 0 });
            };

            //_report.Add(DrinkType.Coffee, new Report() { TotalOrder = 0, TotalCost = 0 });

            //_report.Add(DrinkType.Tea, new Report() { TotalOrder = 0, TotalCost = 0 });

            //_report.Add(DrinkType.HotChoc, new Report() { TotalOrder = 0, TotalCost = 0 });

            //_report.Add(DrinkType.Orange, new Report() { TotalOrder = 0, TotalCost = 0 });
        }




        //Constructor. In the constructor - calling DrinkType from DrinkType File)
        //can have more logic later on by putting this PlaceOrder method here


        public Drink PlaceOrder(DrinkType drinkType, int sugar, string isExtraHotInput)
        {
            
            //_totalCost += price;

            
            Drink drink = null;
            //instantiate drink first
            SaveStock(drinkType);
            switch (drinkType)
            {
                case DrinkType.Coffee:
                    drink = new Coffee(drinkType, sugar, IsExtraHot(isExtraHotInput));
                    break;
                //can return for any case - if not coffee. don't need this if have all the drinks.

                case DrinkType.Tea:
                    drink = new Tea(drinkType, sugar, IsExtraHot(isExtraHotInput));
                    break;
                case DrinkType.HotChoc:
                    drink = new HotChoc(drinkType, sugar, IsExtraHot(isExtraHotInput));
                    break;
                case DrinkType.Orange:
                    drink = new Orange(drinkType);
                    break;

            }

            SaveOrder(drinkType, drink.Price);

            return drink;
            //return new Drink(drinktype, sugar, temp, message, price);
        }

        public decimal GetBalance(decimal price, decimal money)
        {
            return money - price;
        }

      


        
        public int GetCoffeeStock()
        {
            return _coffeeStock;
        }

        public int GetTeaStock()
        {
            return _teaStock;
        }

        public int GetChocStock()
        {
            return _chocStock;
        }

        public int GetOrangeStock()
        {
            return _orangeStock;
        }


        //every time order drink, want to increment order and cost in the dictionary
        private void SaveOrder(DrinkType drinkType, decimal price)
        {

            //if (_report.ContainsKey(drinkType))
            //{
                _report[drinkType].TotalOrder++;
                _report[drinkType].TotalCost += price;

                //12-3 ADDED THIS 
                //_report[drinkType].TotalCoffee--;
                
            //}
            //else
            //{
            //    _report.Add(drinkType, new Report() { TotalOrder = 1, TotalCost = price });
            //}

          
        }

        public Report GetTotalTransactions()
        {
            var Report = new Report();
            foreach (var eachDrink in _report.Keys)
            {
                Report.TotalCost += _report[eachDrink].TotalCost;
                Report.TotalOrder += _report[eachDrink].TotalOrder;

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


        private void SaveStock(DrinkType drinkType)
        {
            switch (drinkType)
            {
                case DrinkType.Tea:

                    _teaStock--;

                    break;
                case DrinkType.Coffee:

                    _coffeeStock--;
                    break;
                case DrinkType.HotChoc:

                    _chocStock--;
                    break;
                case DrinkType.Orange:

                    _orangeStock--;
                    break;

            }
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