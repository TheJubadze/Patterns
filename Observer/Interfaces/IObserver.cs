namespace Observer.Interfaces
{
    interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
