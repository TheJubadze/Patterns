namespace Decorator.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(PortionSize portionSize) : base("Dark Roast Coffee", portionSize)
        {
        }
        public override double Cost => .99;
    }
}
