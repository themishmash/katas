using System;
namespace coffeeMachine
{
    public class Orange : Drink
    {
        public override decimal Price {  get { return 0.6M;  } }
        public Orange(DrinkType drinkType) : base(drinkType)
        {
        }
    }
}
