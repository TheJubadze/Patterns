using System;

namespace TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
