using System;
namespace CombinedPatterns.Interfaces
{
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}
