using System;

namespace Command.Devices
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo is ON");
        }
        public void Off()
        {
            Console.WriteLine("Stereo is OFF");
        }
        public void SetCd()
        {
            Console.WriteLine("Stereo: CD is setted");
        }
        public void SetDvd()
        {
            Console.WriteLine("Stereo: DVD is setted");
        }
        public void SetRadio()
        {
            Console.WriteLine("Stereo: Radio is setted");
        }
        public void SetVolume(int vol)
        {
            Console.WriteLine($"Stereo: volume is setted to {vol}");
        }
    }
}
