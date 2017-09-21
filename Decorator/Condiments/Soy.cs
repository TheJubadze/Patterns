namespace Decorator.Condiments
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage) : base($"{beverage.Description}, Soy", beverage.Size)
        {
            _beverage = beverage;
        }
        
        public override double Cost => .15 + _beverage.Cost;
    }
}
