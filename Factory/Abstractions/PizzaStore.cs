namespace Factory.Abstractions
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
        {
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        public abstract Pizza CreatePizza(PizzaType type);
    }

}
