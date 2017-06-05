using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MakingBurgers
{
    public abstract class ToppingsDecorator : Burger
    {
        protected Burger BasicBurger;

        public ToppingsDecorator(Burger ClientBurger)
        {
            BasicBurger = ClientBurger;
        }

        public override string GetInfo()
        {
            return BasicBurger.GetInfo();
        }

        public override double GetPrice()
        {
            return BasicBurger.GetPrice();
        }
    }
}
