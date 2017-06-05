using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MakingBurgers.Toppings
{
    public class Beef : ToppingsDecorator
    {
        public Beef(Burger ClientBurger) : base(ClientBurger) { }

        public override string GetInfo()
        {
            return BasicBurger.GetInfo() + "with beef ";
        }

        public override double GetPrice()
        {
            return BasicBurger.GetPrice() + 3;
        }

    }
}
