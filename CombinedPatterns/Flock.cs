using System.Collections.Generic;
using CombinedPatterns.Interfaces;

namespace CombinedPatterns
{
    public class Flock : IQuackable
    {
        private List<IQuackable> quackers;
        public Flock()
        {
            quackers = new List<IQuackable>();
        }
        public void Add(IQuackable quackable)
        {
            quackers.Add(quackable);
        }

        public void NotifyObservers()
        {
            foreach (var q in quackers)
                q.NotifyObservers();
        }

        public void Quack()
        {
            foreach (var q in quackers)
                q.Quack();
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (var q in quackers)
                q.RegisterObserver(observer);
        }
    }
}
