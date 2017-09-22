using Factory.Abstractions;
using Factory.Factories;
using Factory.Pizzas;

namespace Factory.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = null;
            IPizzaIngredientsFactory factory = new NYPizzaIngredientFactory();
            switch (type)
            {
                case PizzaType.Cheese: pizza = new CheesePizza(factory){Name = "NY Cheese Pizza"}; break;
                case PizzaType.Clam: pizza = new ClamPizza(factory){Name = "NY Clam Pizza"}; break;
            }
            return pizza;
        }
    }
}
