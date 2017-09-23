using Factory.Abstractions;
using Factory.Stores;

namespace Factory
{
    class Program
    {
        static void Main()
        {
            var nyStore = new ChicagoPizzaStore();
            nyStore.OrderPizza(PizzaType.Cheese);
            nyStore.OrderPizza(PizzaType.Clam);
        }
    }
}
