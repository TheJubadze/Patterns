using System;
using Duck.FlyImplemets;
using Duck.QuackImplemets;

namespace Duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
