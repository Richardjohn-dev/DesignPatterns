using System;

namespace RemoteControlWithSlots
{
    public class GarageDoor
    {
        private readonly string _location;

        public GarageDoor(string location)
        {
            _location = location;
        }
        public void Up()
        {
            Console.WriteLine("Garage Door is OPENING.");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door moving CLOSING.");
        }
        public void Stop()
        {
            Console.WriteLine("Garage Door STOPPED.");
        }
        public void LightOn()
        {
            Console.WriteLine("Garage Door Lights are ON.");
        }
        public void LightOff()
        {
            Console.WriteLine("Garage Door Lights are OFF.");
        }
    }
}
