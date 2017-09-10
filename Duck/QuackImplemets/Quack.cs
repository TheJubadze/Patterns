using System;
using Duck.Interfaces;

namespace Duck.QuackImplemets
{
    public class Quack : IQuackBehavior
    {
        public void ToQuack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
