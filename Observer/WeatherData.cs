using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer
{
    class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;
        private float temp;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObs(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObs(IObserver o)
        {
            if (_observers.Contains(o))
            {
                _observers.Remove(o);
            }
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(temp, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            Notify();
        }

        public void SetMeasurements(float t, float h, float p)
        {
            temp = t;
            humidity = h;
            pressure = p;
            MeasurementsChanged();
        }
    }
}
