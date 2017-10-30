using CombinedPatterns.Interfaces;
namespace CombinedPatterns.Ducks
{
    public class DuckCall : IQuackable
    {
        Observable observable;
        public DuckCall()
        {
            observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            System.Console.WriteLine("Kwak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
