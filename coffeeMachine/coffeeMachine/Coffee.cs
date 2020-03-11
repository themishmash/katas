using System;
namespace coffeeMachine
{
    public class Coffee : Drink
    {
        public override decimal Price { get { return 0.4M;  } }

        public Coffee(DrinkType drinkType, int sugarLevel, bool isExtraHot) : base(drinkType, sugarLevel, isExtraHot)
        {
            
        }
    }
}
