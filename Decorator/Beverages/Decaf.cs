namespace Decorator.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf(PortionSize portionSize) : base("Without coffeine", portionSize)
        {
        }
        public override double Cost => 1.05;
    }
}
