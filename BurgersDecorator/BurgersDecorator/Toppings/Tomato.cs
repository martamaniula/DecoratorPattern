using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MakingBurgers.Toppings
{
    public class Tomato : ToppingsDecorator
    {
        public Tomato(Burger ClientBurger) : base(ClientBurger) { }

        public override string GetInfo()
        {
            return BasicBurger.GetInfo() + "with tomato ";
        }

        public override double GetPrice()
        {
            return BasicBurger.GetPrice() + 1;
        }

    }
}
