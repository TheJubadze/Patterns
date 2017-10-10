namespace TemplateMethod
{
    class Program
    {
        public static void Main()
        {
            CoffeeWithHook coffeeWithHook = new CoffeeWithHook();
            coffeeWithHook.PrepareRecipe();
        }
    }
}
