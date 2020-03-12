using System;
namespace coffeeMachine
{
    public class HotChoc : Drink
    {
        public override decimal Price { get { return 0.5M;  } }
        public HotChoc(DrinkType drinkType, int sugarLevel, bool isExtraHot) : base(drinkType, sugarLevel, isExtraHot)
        {

        }
    }
}
