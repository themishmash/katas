using System;
namespace coffeeMachine
{
    public class Coffee : Drink
    {
        public override decimal Price { get { return 0.6M;  } }

     

        public Coffee(DrinkType drinkType, int sugarLevel, bool isExtraHot) : base(drinkType, sugarLevel, isExtraHot)
        {
            //this will increment each time a coffee instance is made
          
        }


    }
}
