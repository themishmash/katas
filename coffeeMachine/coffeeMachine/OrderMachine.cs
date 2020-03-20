

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

// TODO: need a list variable to remember all created orders and method to retrieve this list. Will need to create this list as part of the constructor. 

        //Method. In this method- calling DrinkType from DrinkType File)
        //can have more logic later on by putting this PlaceOrder method here

        public Order StartOrder(DrinkType drinkType)
        {
            

            
            Drink drink = null;
            //instantiate drink first
            
            switch (drinkType)
            {
                case DrinkType.Coffee:
                    drink = new Coffee();
                    break;

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

            var order = CreateOrder(drink);

           
            return order;
            
        }


        public void AddSugar(Order order, int sugar)
        {
            order.SugarLevel = sugar;
        }

        public void ExtraHot (Order order, bool extraHot)
        {
            order.IsExtraHot = extraHot;
        }


        public void CustomerPays(Order order, decimal amount)
        {
            order.AmountPaid = amount;
        }

        
        private Order CreateOrder(Drink drink)
        {

            var order = new Order();
            order.Drink = drink;

//TODO Add new order to list of orders here

            return order;
          

        }
        


    }


}

