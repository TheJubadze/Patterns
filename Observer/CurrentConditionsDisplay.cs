using System;
using Observer.Interfaces;

namespace Observer
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temp;
        private float humidity;

        public void Update(float t, float h, float p)
        {
            temp = t;
            humidity = h;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temp} degrees and {humidity}% humidity");
        }
    }
}
