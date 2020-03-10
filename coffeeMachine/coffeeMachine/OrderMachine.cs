

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

        private int _drinkCount;


        private decimal _totalCost;

        //count of drinks
        private int _coffeeCount;
        private int _teaCount;
        private int _chocCount;
        private int _orangeCount;

        //starting stock of drinks
        private int _coffeeStock = 10;
        private int _teaStock = 10;
        private int _chocStock = 10;
        private int _orangeStock = 10;


        //Constructor. In the constructor - calling DrinkType from DrinkType File)
        //can have more logic later on by putting this PlaceOrder method here


        public Drink PlaceOrder(DrinkType drinktype, int sugar, string temp, string message, decimal price)
        {
            //adding the drinkcount 
            _drinkCount++;
            _totalCost += price;
            SaveOrder(drinktype);
            return new Drink(drinktype, sugar, temp, message, price);
        }

        public decimal GetBalance(decimal price, decimal money)
        {
            return money - price;
        }

        public int GetDrinkCount()
        {
            return _drinkCount;
        }

        public decimal GetTotalCost()
        {
            return _totalCost;
        }


        public int GetCoffeeCount()
        {
            
            return _coffeeCount;
        }

        public int GetTeaCount()
        {
            return _teaCount;
        }

        public int GetChocCount()
        {
            return _chocCount;
        }

        public int GetOrangeCount()
        {
            return _orangeCount;
        }



        private void SaveOrder(DrinkType drinkType)
        {
            switch (drinkType)
            {
                case DrinkType.Tea:
                    
                    _teaCount++;
                    
                    break;
                case DrinkType.Coffee:
                  
                    _coffeeCount++;
                    break;
                case DrinkType.HotChoc:
                    
                    _chocCount++;
                    break;
                case DrinkType.Orange:
                    
                    _orangeCount++;
                    break;

            }
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