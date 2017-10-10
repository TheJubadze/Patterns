using System;

namespace TemplateMethod
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override bool CustomerWantsCondiments
        {
            get
            {
                var answer = GetInput();
                if (answer.ToLower().StartsWith("y"))
                    return true;
                return false;
            }
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        private string GetInput()
        {
            Console.WriteLine("Would you like Milk and Sugar? (y/n)");
            var answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer))
                return "no";
            return answer;
        }
    }
}