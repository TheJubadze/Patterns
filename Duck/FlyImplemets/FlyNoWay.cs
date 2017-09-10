using System;
using Duck.Interfaces;

namespace Duck.FlyImplemets
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly ((");
        }
    }
}
