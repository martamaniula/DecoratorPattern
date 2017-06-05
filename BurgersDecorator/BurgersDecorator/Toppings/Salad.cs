using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MakingBurgers
{
    public class Salad : ToppingsDecorator
    {
        public Salad(Burger ClientBurger) : base(ClientBurger) { }

        public override string GetInfo()
        {
            return BasicBurger.GetInfo() + "with salad ";
        }

        public override double GetPrice()
        {
            return BasicBurger.GetPrice() + 0.5;
        }

    }
}
