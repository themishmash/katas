using System;
namespace coffeeMachine
{
    public class Order
    {
        public Drink Drink { get; set; }
        
        public int SugarLevel { get; set; }
        public bool IsExtraHot { get; set; }
        public decimal AmountPaid { get; set; }
        public string Message { get; set; }


        //only used here so it is private function
        public bool NeedsStick()
        {
            return SugarLevel > 0;
        }


        public Order()
        {
        }
    }
}
