using System;

namespace RemoteControlWithSlots
{
    public class Stereo
    {
        private readonly string _location;

        public Stereo(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine($"{_location} Stereo is On");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} Stereo is Off");
        }

        public void SetCd()
        {
            Console.WriteLine($"{_location} Stereo is set for CD input");
        }

        public void SetDvd()
        {
            Console.WriteLine($"{_location} Stereo is set for DVD input");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{_location} Stereo is set for Radio");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"{_location} Stereo volume set to {volume}");
        }
    }
}
