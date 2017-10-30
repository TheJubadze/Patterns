using System;
namespace CombinedPatterns.Interfaces
{
    public interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}
