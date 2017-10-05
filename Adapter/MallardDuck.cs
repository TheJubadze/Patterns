using System;
using Adapter.Interfaces;

namespace Adapter
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }

        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }
}
