using System;
using Duck.Interfaces;

namespace Duck
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { protected get; set; }
        public IQuackBehavior QuackBehavior { protected get; set; }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.ToQuack();
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
