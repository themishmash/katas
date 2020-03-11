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
        public DrinkType DrinkType { get; }

        public int SugarLevel { get;  }

        public bool IsExtraHot { get; }

        //made boolean
        public bool Stick
        {
            get
            {
                return GetStick(SugarLevel);
            }
        }
        //public string Message { get; }


       //if make virtual - children can override
        public virtual decimal Price { get; }




        



        //public static void totalCost()
        //{
        //    foreach (Drink drink in drinkList)
        //    {
        //        Console.WriteLine(drinkList.Price);
        //    }
        //}





//Constructor
        public Drink (DrinkType drinkType, int sugarLevel, bool isExtraHot)
        {
            DrinkType = drinkType;
            SugarLevel = sugarLevel;
            IsExtraHot = isExtraHot;
           
        }



        //only used here so it is private function
        private bool GetStick(int sugarLevel)
        {
            return sugarLevel > 0;
        }


   




      
        

        //public override string ToString()
        //{
        //    return ($"{_drinkType}:{_sugar}:{_stick}:{_message}");

        //}


    }


}