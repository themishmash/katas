using System;
namespace coffeeMachine
{
    public class Tea : Drink
    {
        public override decimal Price { get { return 0.4M; } }
        public Tea(DrinkType drinkType, int sugarLevel, bool isExtraHot) : base(drinkType, sugarLevel, isExtraHot)
        {
        }
    }
}
