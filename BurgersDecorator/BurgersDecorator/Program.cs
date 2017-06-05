using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakingBurgers.Toppings;

namespace MakingBurgers
{
    class Program
    {
        static void Main(string[] args)
        {
            Burger burger = new BBQSauce(new Beef(new Onion(new Salad(new Tomato(new JustBunsBurger())))));

            Console.WriteLine(burger.GetInfo());

            Console.WriteLine("Price: {0} ", burger.GetPrice());
            
        }
    }
}
