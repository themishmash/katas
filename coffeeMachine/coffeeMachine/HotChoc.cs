using System;
namespace coffeeMachine
{
    public class HotChoc : Drink
    {
        public HotChoc()
        {
            DrinkType = DrinkType.HotChoc;
            Price = 0.5M;
            CanHaveSugar = true;
            CanBeExtraHot = true;
        }
    }
}
