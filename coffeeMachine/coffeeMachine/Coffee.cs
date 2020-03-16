using System;
namespace coffeeMachine
{
    public class Coffee : Drink
    {
        public Coffee ()
        {
            //get { return 0.6M;  }

            //Starting to do a typed a enum
            DrinkType = DrinkType.Coffee;
            Price = 0.6M;
            CanHaveSugar = true;
            CanBeExtraHot = true;
           
                }

        


    }
}
