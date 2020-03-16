using System;
namespace coffeeMachine
{
    public class Orange : Drink
    {
        public Orange()
        {
            DrinkType = DrinkType.Orange;
            Price = 0.6M;
            CanHaveSugar = false;
            CanBeExtraHot = false;
        }
    }
}
