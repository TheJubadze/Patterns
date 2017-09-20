using System;
using System.Collections.Generic;

namespace Observer.NET
{
    class WeatherData : IObservable<WeatherValue>, IDisposable
    {
        private readonly List<IObserver<WeatherValue>> _observers;
        public WeatherValue Value { get; set; }
        public WeatherData()
        {
            _observers = new List<IObserver<WeatherValue>>();
        }

        public IDisposable Subscribe(IObserver<WeatherValue> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<WeatherValue>> _observers;
            private readonly IObserver<WeatherValue> _observer;

            public Unsubscriber(List<IObserver<WeatherValue>> observers, IObserver<WeatherValue> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }

        public void SetMeasurements(float t, float h, float p)
        {
            foreach (var observer in _observers)
            {
                try
                {
                    if (Math.Abs(t - 1) < 0.1)
                        throw new ArgumentException("Temperature is ONE!");

                    Value = new WeatherValue {Temp = t, Hummidity = h, Pressure = p};
                    observer.OnNext(Value);
                }
                catch (Exception e)
                {
                    observer.OnError(e);
                }
            }
        }

        public void Dispose()
        {
            foreach (var observer in _observers)
            {
                observer.OnCompleted();
            }
            _observers.Clear();
        }

    }
}
