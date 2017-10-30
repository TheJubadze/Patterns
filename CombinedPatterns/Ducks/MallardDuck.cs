using CombinedPatterns.Interfaces;

namespace CombinedPatterns.Ducks
{
    public class MallardDuck : IQuackable
    {
        Observable observable;
        public MallardDuck()
        {
            observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            System.Console.WriteLine("Quack");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
