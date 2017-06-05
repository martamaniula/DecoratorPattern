using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MakingBurgers.Toppings
{
    public class Onion : ToppingsDecorator
    {
        public Onion(Burger ClientBurger) : base(ClientBurger) { }

        public override string GetInfo()
        {
            return BasicBurger.GetInfo() + "with onion ";
        }

        public override double GetPrice()
        {
            return BasicBurger.GetPrice() + 0.7;
        }

    }
}
