using System;
namespace coffeeMachine
{
    public class Tea : Drink
    {
        public Tea()
        //public override decimal Price { get { return 0.4M; } }
        {
            DrinkType = DrinkType.Tea;
            Price = 0.4M;
            CanHaveSugar = true;
            CanBeExtraHot = true;
        }

    }
}
