namespace Decorator.Condiments
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage) : base($"{beverage.Description}, Whip", beverage.Size)
        {
            _beverage = beverage;
        }
        public override double Cost => .10 + _beverage.Cost;
    }
}
