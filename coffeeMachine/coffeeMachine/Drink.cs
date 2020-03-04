//First iteration - Making drinks
//In this iteration, your task is to implement the logic (starting from a simple class) that translates orders from customers of the coffee machine to the drink maker.Your code will use the drink maker protocol(see below) to send commands to the drink maker.

namespace coffeeMachine
{
    
    //This is the actual drink class. Represents beverage. Doesn't show to user

    public class Drink
        
    {
        //best practise to have private and public
        //private propertie for class use underscore. 

        //Properties
        public DrinkType DrinkType { get; }

       
        public int Sugar { get;  }
        public string Stick
        {
            get
            {
                return GetStick(Sugar);
            }
        }
        public string Message { get; }

        public decimal Price { get; }



        public Drink (DrinkType drinkType, int sugar, string message, decimal price)
        {
            DrinkType = drinkType;
            Sugar = sugar;
            Message = message;
            Price = price;
        }

        //only used here so it is private function
        private string GetStick(int sugar)
        {
            if (sugar > 0)

                return "0";

            return "";

        }

      
        

        //public override string ToString()
        //{
        //    return ($"{_drinkType}:{_sugar}:{_stick}:{_message}");

        //}


    }


}