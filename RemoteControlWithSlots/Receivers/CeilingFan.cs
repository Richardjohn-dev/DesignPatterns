using System;

namespace RemoteControlWithSlots
{
    public class CeilingFan
    {
        private readonly string _location;
        private FanSpeed _fanSpeed;

        public CeilingFan(string location)
        {
            _location = location;
            _fanSpeed = FanSpeed.Off;
        }

        public void High()
        {
            _fanSpeed = FanSpeed.High;
            Console.WriteLine($"{_location} ceiling fan is on high");
        }

        public void Medium()
        {
            _fanSpeed = FanSpeed.Medium;
            Console.WriteLine($"{_location} ceiling fan is on medium");
        }

        public void Low()
        {
            _fanSpeed = FanSpeed.Low;
            Console.WriteLine($"{_location} ceiling fan is on low");
        }

        public void Off()
        {
            _fanSpeed = FanSpeed.Off;
            Console.WriteLine($"{_location} ceiling fan is off");
        }

        public FanSpeed GetSpeed()
        {
            return _fanSpeed;
        }

    }

    public enum FanSpeed
    {
        Off,
        Low,
        Medium,
        High
    }
}
