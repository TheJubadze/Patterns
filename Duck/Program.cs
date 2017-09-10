using Duck.FlyImplemets;

namespace Duck
{
    class Program
    {
        static void Main()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            Duck modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.FlyBehavior = new FlyRocketPowered();
            modelDuck.PerformFly();
        }
    }
}
