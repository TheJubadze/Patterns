using System.Collections.Generic;
using Factory.Abstractions;
using Factory.Abstractions.Ingredients;
using Factory.Ingredients;

namespace Factory.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientsFactory
    {
        public Dough GetDough()
        {
            return new ThickChrustDough();
        }

        public Sauce GetSauce()
        {
            return new PlumTomatoSauce();
        }

        public Cheese GetCheese()
        {
            return new ReggianoCheese();
        }

        public List<Veggie> GetVeggies()
        {
            return new List<Veggie>{new Spinach(), new EggPlant(), new BlackOlives()};
        }

        public Pepperoni GetPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams GetClams()
        {
            return new FrozenClams();
        }
    }
}
