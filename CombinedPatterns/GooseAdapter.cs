using CombinedPatterns.Interfaces;
namespace CombinedPatterns
{
    public class GooseAdapter : IQuackable
    {
        private Goose goose;
        public GooseAdapter(Goose g)
        {
            goose = g;
        }

        public void NotifyObservers()
        {
            goose.NotifyObservers();
        }

        public void Quack()
        {
            goose.Honk();
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            goose.RegisterObserver(observer);
        }
    }
}
