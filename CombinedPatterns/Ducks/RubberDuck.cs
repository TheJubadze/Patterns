using CombinedPatterns.Interfaces;
namespace CombinedPatterns.Ducks
{
    public class RubberDuck : IQuackable
    {
        Observable observable;
        public RubberDuck()
        {
            observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            System.Console.WriteLine("Sqweak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
