using System;
using Factory.Abstractions;

namespace Factory.Pizzas
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientsFactory _pizzaIngredientsFactory;

        public CheesePizza(IPizzaIngredientsFactory pizzaIngredientsFactory)
        {
            _pizzaIngredientsFactory = pizzaIngredientsFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name} pizza...");
            Dough = _pizzaIngredientsFactory.GetDough();
            Sauce = _pizzaIngredientsFactory.GetSauce();
            Veggies = _pizzaIngredientsFactory.GetVeggies();
        }
    }
}
