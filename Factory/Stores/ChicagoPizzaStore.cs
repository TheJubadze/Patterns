using Factory.Abstractions;
using Factory.Factories;
using Factory.Pizzas;

namespace Factory.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = null;
            IPizzaIngredientsFactory factory = new ChicagoPizzaIngredientFactory();
            switch (type)
            {
                case PizzaType.Cheese: pizza = new CheesePizza(factory){Name = "Chicago Cheese Pizza"}; break;
                case PizzaType.Clam: pizza = new ClamPizza(factory){Name = "Chicago Clam Pizza"}; break;
            }
            return pizza;
        }
    }
}
