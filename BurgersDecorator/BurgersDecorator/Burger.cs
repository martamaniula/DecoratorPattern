using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingBurgers
{
    public abstract class Burger
    {
        public abstract string GetInfo();

        public abstract double GetPrice();
    }
}
