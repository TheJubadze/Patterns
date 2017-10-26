using System;

namespace State.States
{
    class SoldOutState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.State = _gumballMachine.HasQuarterState;
                Console.WriteLine("Quarter Inserted");
            }
            else
            {
                Console.WriteLine("ERROR. Gumball machine is empty.");
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("There is no money inside.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You cant turn it, cause it's empty");
        }

        public void Dispense()
        {
            Console.WriteLine("ERROR. Nothing to dispense");
        }
    }
}
