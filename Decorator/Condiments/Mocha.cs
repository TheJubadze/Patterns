namespace Decorator.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage) : base ($"{beverage.Description}, Mocha", beverage.Size)
        {
            _beverage = beverage;
        }
        public override double Cost => .20 + _beverage.Cost;
    }
}
