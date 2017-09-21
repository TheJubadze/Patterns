namespace Decorator.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso(PortionSize portionSize) : base("Espresso", portionSize)
        {
        }
        public override double Cost => 1.99;
    }
}
