using System.Collections.Generic;
using CombinedPatterns.Interfaces;
namespace CombinedPatterns
{
    public class Observable : IQuackObservable
    {
        IQuackObservable duck;
        List<IObserver> observers = new List<IObserver>();

        public Observable(IQuackObservable d)
        {
            duck = d;
        }

        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update(duck);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
    }
}
