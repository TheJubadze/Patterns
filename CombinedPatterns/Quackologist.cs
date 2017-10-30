using System;
using CombinedPatterns.Interfaces;

namespace CombinedPatterns
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quackologist: {duck} has just quacked.");
        }
    }
}
