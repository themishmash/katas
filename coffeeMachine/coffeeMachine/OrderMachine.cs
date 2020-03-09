

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

        public static int DrinkCount = 0;

        public OrderMachine ()
        {
            DrinkCount++;
        }



        //MAKING IT INTO LIST?
        public static List<Drink> drinkList = new List<Drink>();

        public static void AddDrink(Drink drink)

        {
            drinkList.Add(drink);

        }

        public static int numberOfdrinks
        {
            get
            {
                return drinkList.Count;
            }
        }

        
        

    



    //Constructor. In the constructor - calling DrinkType from DrinkType File)
    //can have more logic later on by putting this PlaceOrder method here
    public Drink PlaceOrder(DrinkType drinktype, int sugar, decimal price)
        {

            return new Drink(drinktype, sugar, "", "", price);

            //eg can have method to calculate order type/amount

        }

        public Drink PlaceOrder(DrinkType drinktype, int sugar, string temp, string message, decimal price)
        {
            return new Drink(drinktype, sugar, temp, message, price);
        }

        public decimal GetBalance(decimal price, decimal money)
        {
            return money - price;
        }


        

        //This returns true or false - this has been moved to Order.cs and can no longer be bool 
        //public static bool needsStick(int sugar)

        //{

        //    return sugar > 0;
        //}




    }


}
