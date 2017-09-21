using System;
using Decorator.Beverages;
using Decorator.Condiments;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            Beverage coffee = new DarkRoast(PortionSize.m);
            Console.WriteLine($"{coffee.Description}: ${coffee.Cost}");

            coffee = new Mocha(coffee);
            Console.WriteLine($"{coffee.Description}: ${coffee.Cost}");

            coffee = new Soy(coffee);
            Console.WriteLine($"{coffee.Description}: ${coffee.Cost}");
        }
    }
}
