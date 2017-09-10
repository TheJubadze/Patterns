using System;
using Duck.Interfaces;

namespace Duck.QuackImplemets
{
    public class Squeak : IQuackBehavior
    {
        public void ToQuack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
