using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingBurgers
{
    public class JustBunsBurger : Burger
    {
        public override string GetInfo()
        {
            return "Buns ";
        }

        public override double GetPrice()
        {
            return 1.5;
        }
    }
}
