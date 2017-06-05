using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingBurgers.Toppings
{
    public class BBQSauce : ToppingsDecorator
    {
        public BBQSauce(Burger ClientBurger) : base(ClientBurger) { }

        public override string GetInfo()
        {
            return BasicBurger.GetInfo() + "with BBQ sauce ";
        }

        public override double GetPrice()
        {
            return BasicBurger.GetPrice() + 1;
        }

    }
}
