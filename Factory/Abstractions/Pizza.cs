using System;
using System.Collections.Generic;
using Factory.Abstractions.Ingredients;

namespace Factory.Abstractions
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected Dough Dough;
        protected Sauce Sauce;
        protected Cheese Cheese;
        protected Clams Clams;
        protected List<Veggie> Veggies;


        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza...");
        }
    }


    public enum PizzaType
    {
        Cheese, Clam
    }
}
