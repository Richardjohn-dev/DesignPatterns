using System;

namespace RemoteCommander
{
    class Program
    {
        static void Main(string[] args)
        {
            // test remote control

            SimpleRemoteControl remote = new(); // Invoker
            Light light = new(); // reciever of the request
            LightOnCommand lightOn = new LightOnCommand(light);


            GarageDoor garageDoor = new(); // Receiver 2
            GarageDoorOpenCommand openGarage = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn); // Command (lightOn) passed to Invoker (remote)
            remote.buttonWasPressed(); // simulate


            remote.SetCommand(openGarage); // strategy pattern?
            remote.buttonWasPressed();

            Console.WriteLine("Hello World!");
        }
    }

    public interface ICommand
    {
         public void Execute();
    }

    public class Light
    {
        public void On()
        {
            Console.WriteLine("Lights are ON.");
        }

        public void Off()
        {
            Console.WriteLine("Lights are OFF.");
        }

    }

    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.On();
        }
    }

    public class SimpleRemoteControl
    {
        private ICommand _buttonSlot; // slot stores the command, which controls one device.
        public SimpleRemoteControl() {}

        public void SetCommand(ICommand command) // is this strategy pattern?
        {
            _buttonSlot = command;
        }
        public void buttonWasPressed()
        {
            _buttonSlot.Execute();
        }
    }

   

    //
    public class GarageDoor
    {
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

    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}
