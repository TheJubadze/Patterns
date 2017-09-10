using System;
using Duck.Interfaces;

namespace Duck.FlyImplemets
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
