using System;

namespace RemoteControlWithSlots
{
    public class Light
    {
        private readonly string _location;

        public Light(string location)
        {
            _location = location;
        }
        public void On()
        {
            Console.WriteLine($"{_location} Lights are ON.");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} Lights are OFF.");
        }

    }
}
