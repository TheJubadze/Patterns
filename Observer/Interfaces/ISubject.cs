namespace Observer.Interfaces
{
    interface ISubject
    {
        void RegisterObs(IObserver o);
        void RemoveObs(IObserver o);
        void Notify();
    }
}
