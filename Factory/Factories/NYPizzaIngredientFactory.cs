using System.Collections.Generic;
using Factory.Abstractions;
using Factory.Abstractions.Ingredients;
using Factory.Ingredients;

namespace Factory.Factories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientsFactory
    {
        public Dough GetDough()
        {
            return new ThinChrustDough();
        }

        public Sauce GetSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese GetCheese()
        {
            return new Mozarella();
        }

        public List<Veggie> GetVeggies()
        {
            return new List<Veggie>{new Onion(), new Garlic(), new Mushroom(), new RedPepper()};
        }

        public Pepperoni GetPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams GetClams()
        {
            return new FreshClams();
        }
    }
}
