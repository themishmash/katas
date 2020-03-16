//First iteration - Making drinks
//In this iteration, your task is to implement the logic (starting from a simple class) that translates orders from customers of the coffee machine to the drink maker.Your code will use the drink maker protocol(see below) to send commands to the drink maker.

using System.Collections.Generic;

namespace coffeeMachine
{



    //This is the actual drink class. Represents beverage. Doesn't show to user

 
    public class Drink
        
    {

       
        //best practise to have private and public
        //private propertie for class use underscore. 

        //Properties
        //protected set allows things to inherit from it to set
        public DrinkType DrinkType { get; protected set; }

        public bool CanHaveSugar { get; protected set; }

        public bool CanBeExtraHot { get; protected set; }
     
        public decimal Price { get; protected set; }




    }


}