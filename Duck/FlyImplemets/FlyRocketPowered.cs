using System;
using Duck.Interfaces;

namespace Duck.FlyImplemets
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
