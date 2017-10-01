using System;
using Command.Commands;
using Command.Devices;
using Command.RemoteControls;

namespace Command
{
    class Program
    {
        static void Main()
        {
            var remote = new RemoteControl();

            var light = new Light();
            var stereo = new Stereo();

            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);
            var stereoOnCommand = new StereoOnCommand(stereo);
            var stereoOffCommand = new StereoOffCommand(stereo);
            var stereoOnCdCommand = new StereoOnCdCommand(stereo);

            remote.OnCommands[0] = lightOnCommand;
            remote.OnCommands[1] = stereoOnCommand;
            remote.OnCommands[2] = stereoOnCdCommand;
            remote.OffCommands[0] = lightOffCommand;
            remote.OffCommands[1] = stereoOffCommand;

            remote.OnButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OnButtonWasPushed(2);
            Console.WriteLine(remote);
            remote.OffButtonWasPushed(0);
            remote.OffButtonWasPushed(1);
            remote.UndoButtonPushed();
        }
    }
}
