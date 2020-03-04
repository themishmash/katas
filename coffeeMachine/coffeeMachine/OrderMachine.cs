//First iteration - Making drinks
//In this iteration, your task is to implement the logic (starting from a simple class) that translates orders from customers of the coffee machine to the drink maker.Your code will use the drink maker protocol(see below) to send commands to the drink maker.

//The coffee machine can serves 3 type of drinks: tea, coffee, chocolate.

//Requirements
//The drink maker should receive the correct instructions for my coffee / tea / chocolate order
//I want to be able to send instructions to the drink maker to add one or two sugars
//When my order contains sugar the drink maker should add a stick(touillette) with it
//Drink maker protocol
//The drink maker receives string commands from your code to make the drinks.It can also deliver info messages to the customer if ordered so.The instructions it receives follow this format:

//"T:1:0" (Drink maker makes 1 tea with 1 sugar and a stick)

//"H::" (Drink maker makes 1 chocolate with no sugar - and therefore no stick)

//"C:2:0" (Drink maker makes 1 coffee with 2 sugars and a stick)

//"M:message-content" (Drink maker forwards any message received onto the coffee machine interface for the customer to see)
//Implementation details
//You can represent the incoming order of the customer as you wish.For instance, it could be a simple POJO that contains the order details, or a simple String, try to think of the simplest thing that do the job. Complex matters will arrive soon enough, trust us



//TO DO
// set properties of drinks - drink type, sugar, message
// create constructor
//create method where if sugar - add stick else no stick
//message 

using System;
using System.Collections.Generic;

//this class processes the order. This shows to the user - the actual request

namespace coffeeMachine
{
    
    public class OrderMachine
    {

       
        //Constructor. In the constructor - calling DrinkType from DrinkType File)
        //can have more logic later on by putting this PlaceOrder method here
        public Drink PlaceOrder(DrinkType drinktype, int sugar, decimal price){

            return new Drink(drinktype, sugar, "", price);

            //eg can have method to calculate order type/amount

        }

        public Drink PlaceOrder(DrinkType drinktype, int sugar, string message, decimal price)
        {
            return new Drink(drinktype, sugar, message, price);
        }



        //This returns true or false - this has been moved to Order.cs and can no longer be bool 
        //public static bool needsStick(int sugar)

        //{

        //    return sugar > 0;
        //}

       

    }


}
