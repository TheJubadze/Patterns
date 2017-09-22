using System.Collections.Generic;
using Factory.Abstractions.Ingredients;

namespace Factory.Abstractions
{
    public interface IPizzaIngredientsFactory
    {
        Dough GetDough();
        Sauce GetSauce();
        Cheese GetCheese();
        List<Veggie> GetVeggies();
        Pepperoni GetPepperoni();
        Clams GetClams();
    }
}
