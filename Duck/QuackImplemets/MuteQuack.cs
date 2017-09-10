using System;
using Duck.Interfaces;

namespace Duck.QuackImplemets
{
    public class MuteQuack : IQuackBehavior
    {
        public void ToQuack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
