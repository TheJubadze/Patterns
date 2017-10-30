using System;
using CombinedPatterns.Interfaces;
namespace CombinedPatterns
{
    public class Goose : Interfaces.IQuackObservable
    {
        Observable observable;
        public Goose()
        {
            observable = new Observable(this);
        }
        public void Honk()
        {
            Console.WriteLine("Honk");
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
