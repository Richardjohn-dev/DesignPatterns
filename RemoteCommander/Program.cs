using System;

namespace RemoteCommander
{
    class Program
    {
        static void Main(string[] args)
        {
            // test remote control

            SimpleRemoteControl remote = new(); // Invoker
            LightReceiver light = new(); // reciever of the request
            LightOnCommand lightOn = new LightOnCommand(light);


            GarageDoorReceiver garageDoor = new(); // Receiver 2
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


    public class LightReceiver
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
        private readonly LightReceiver _light;

        public LightOnCommand(LightReceiver light)
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
    public class GarageDoorReceiver
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
        private readonly GarageDoorReceiver _garageDoor;

        public GarageDoorOpenCommand(GarageDoorReceiver garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}
