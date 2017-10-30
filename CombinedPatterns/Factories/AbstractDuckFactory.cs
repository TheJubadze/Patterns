using CombinedPatterns.Interfaces;
namespace CombinedPatterns
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateRedheadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();
        public abstract IQuackable CreateGoose();
    }
}
