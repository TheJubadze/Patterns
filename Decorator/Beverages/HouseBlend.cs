namespace Decorator.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(PortionSize portionSize) : base("House Blend Coffee", portionSize)
        {
        }
        public override double Cost => .89;
    }
}
