using System;
using Adapter.Interfaces;

namespace Adapter
{
    public class DuckAdapter : ITurkey
    {
        private readonly IDuck _duck;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }

        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            _duck.Fly();
            Console.WriteLine("short distance");
        }
    }
}
