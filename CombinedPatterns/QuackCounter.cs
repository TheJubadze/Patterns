using CombinedPatterns.Interfaces;
namespace CombinedPatterns
{
    public class QuackCounter : IQuackable
    {
        IQuackable duck;
        public static int NumberOfQuacks
        {
            get;
            private set;
        }
        public QuackCounter(IQuackable d)
        {
            duck = d;
        }

        public void Quack()
        {
            duck.Quack();
            NumberOfQuacks++;
        }

        public void RegisterObserver(IObserver observer)
        {
            duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            duck.NotifyObservers();
        }
    }
}
