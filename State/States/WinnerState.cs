using System;

namespace State.States
{
    class WinnerState : IState
    {
        private GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("ERROR. You cant insert. Winner!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("ERROR. You cant eject. Winner!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("ERROR. You cant turn. Winner!");
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER!!! Get two!");
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.State = _gumballMachine.SoldOutState;
            }
            else
            {
                _gumballMachine.ReleaseBall();
                if (_gumballMachine.Count > 0)
                {
                    _gumballMachine.State = _gumballMachine.NoQuarterState;
                }
                else
                {
                    Console.WriteLine("OOOps, out of gumballs!");
                    _gumballMachine.State = _gumballMachine.SoldOutState;
                }
            }
        }
    }
}
