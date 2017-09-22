using System;
using Factory.Abstractions;

namespace Factory.Pizzas
{
    public class ClamPizza : Pizza
    {
        private IPizzaIngredientsFactory _pizzaIngredientsFactory;

        public ClamPizza(IPizzaIngredientsFactory pizzaIngredientsFactory)
        {
            _pizzaIngredientsFactory = pizzaIngredientsFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name} pizza...");
            Dough = _pizzaIngredientsFactory.GetDough();
            Sauce = _pizzaIngredientsFactory.GetSauce();
            Clams = _pizzaIngredientsFactory.GetClams();
            Cheese = _pizzaIngredientsFactory.GetCheese();
        }
    }
}
