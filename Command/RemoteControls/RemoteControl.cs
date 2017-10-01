using System.Collections.Generic;
using System.Text;
using Command.Interfaces;

namespace Command.RemoteControls
{
    public class RemoteControl
    {
        public Dictionary<int, ICommand> OnCommands { get; set; } = new Dictionary<int, ICommand>();
        public Dictionary<int, ICommand> OffCommands { get; set; } = new Dictionary<int, ICommand>();
        private ICommand _undoCommand;

        public void OnButtonWasPushed(int slot)
        {
            OnCommands[slot].Execute();
            _undoCommand = OnCommands[slot];
        }
        public void OffButtonWasPushed(int slot)
        {
            OffCommands[slot].Execute();
            _undoCommand = OffCommands[slot];
        }

        public void UndoButtonPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var sb = new StringBuilder("\n=== Remote Control ===\n");

            foreach (var onCommand in OnCommands)
                sb.Append($"[Slot {onCommand.Key}] {onCommand.Value.GetType().Name}\n");

            foreach (var offCommand in OffCommands)
                sb.Append($"[Slot {offCommand.Key}] {offCommand.Value.GetType().Name}\n");

            return sb.ToString();
        }
    }
}
