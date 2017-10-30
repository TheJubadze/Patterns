using CombinedPatterns.Interfaces;
namespace CombinedPatterns.Ducks
{
    public class RedheadDuck : IQuackable
    {
        Observable observable;
        public RedheadDuck()
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
