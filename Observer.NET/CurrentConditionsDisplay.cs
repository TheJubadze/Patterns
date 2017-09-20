using System;

namespace Observer.NET
{
    class CurrentConditionsDisplay : IObserver<WeatherValue>
    {
        public void OnNext(WeatherValue data)
        {
            Console.WriteLine($"Current conditions: {data.Temp} degrees and {data.Hummidity}% humidity");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error);
        }

        public void OnCompleted()
        {
            Console.WriteLine("Work completed");
        }
    }
}
