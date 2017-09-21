namespace Decorator
{
    public abstract class Beverage
    {
        protected string _description;
        protected PortionSize _size;

        protected Beverage(string description, PortionSize size)
        {
            _description = description;
            _size = size;
        }

        public string Description => _description;
        public PortionSize Size => _size;
        public abstract double Cost { get; }
    }
    public enum PortionSize { s, m, l }
}
