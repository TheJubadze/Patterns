using Command.Devices;
using Command.Interfaces;

namespace Command.Commands
{
    public class StereoOnCdCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
