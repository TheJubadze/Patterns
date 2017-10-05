using System;
using Adapter.Interfaces;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            MallardDuck mallardDuck = new MallardDuck();
            WildTurkey wildTurkey = new WildTurkey();

            IDuck turkeyAdapter = new TurkeyAdapter(wildTurkey);
            Console.WriteLine("\nThe Turkey says...");
            wildTurkey.Gobble();
            wildTurkey.Fly();

            Console.WriteLine("\nThe Duck says");
            TestDuck(mallardDuck);

            Console.WriteLine("\nThe TurkeyAdapter says");
            TestDuck(turkeyAdapter);
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
