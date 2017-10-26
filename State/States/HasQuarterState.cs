using System;

namespace State.States
{
    class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;
        Random randomWinner = new Random();
        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You cant insert one more.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.State = _gumballMachine.NoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if (winner == 0 && _gumballMachine.Count > 1)
            {
                _gumballMachine.State = _gumballMachine.WinnerState;
            }
            else
            {
                _gumballMachine.State = _gumballMachine.SoldState;
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
