using CombinedPatterns.Interfaces;
using CombinedPatterns.Ducks;
using CombinedPatterns.Factories;

namespace CombinedPatterns
{
    public class DuckSimulator
    {
        public static void Main()
        {
            var simulator = new DuckSimulator();
            simulator.Simulate(new CountingDuckFactory());
        }
        public void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable goose = duckFactory.CreateGoose();

            var flock = new Flock();
            flock.Add(mallardDuck);
            flock.Add(redheadDuck);
            flock.Add(duckCall);
            flock.Add(rubberDuck);
            flock.Add(goose);

            Quackologist ql = new Quackologist();
            flock.RegisterObserver(ql);

            System.Console.WriteLine("\nDuck simulator");

            Simulate(flock);
            //Simulate(redheadDuck);
            //Simulate(duckCall);
            //Simulate(rubberDuck);
            //Simulate(goose);

            System.Console.WriteLine(QuackCounter.NumberOfQuacks);
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
