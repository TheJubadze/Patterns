namespace Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        protected CondimentDecorator(string description, PortionSize portionSize) : base(description, portionSize)
        {
        }
    }
}
