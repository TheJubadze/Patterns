using Command.Interfaces;

namespace Command.RemoteControls
{
    public class SimpleRemoteControl
    {
        public ICommand Slot { get; set; }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }
    }
}
