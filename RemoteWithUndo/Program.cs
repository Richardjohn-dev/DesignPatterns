using System;

namespace RemoteWithUndo
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();
            // This would all be in its own RemoteLoader class.

            // public class RemoteLoader
            // {
            // Receivers
            var loungeLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen Room");
            var ceilingFan = new CeilingFan("Living Room");
            var garageDoor = new GarageDoor("Garage");
            var stereo = new Stereo("Living Room");


            // COMMANDS

            // The Receiver (Light) of the request gets bound to the commands its encapsulated in.
            // Receiver injected into our Commands through DI

            var loungelightOn = new LightOnCommand(loungeLight);
            var loungelightOff = new LightOffCommand(loungeLight);

            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);

            var ceilingFanOnCommand = new CeilingFanOnCommand(ceilingFan);
            var ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

            var garageDoorUpCommand = new GarageDoorOpenCommand(garageDoor);
            var garageDoorDownCommand = new GarageDoorCloseCommand(garageDoor);

            var stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);


            // set buttons in remote control
            remoteControl.SetCommand(0, loungelightOn, loungelightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOnCommand, ceilingFanOffCommand);
            remoteControl.SetCommand(3, stereoOnWithCd, stereoOff);
            remoteControl.SetCommand(4, garageDoorUpCommand, garageDoorDownCommand);

            // ToDo.. in the book they implement this using lambdas, removing the need for the above concrete class instantiation.

            //remoteControl.SetCommand(5, new LightOnCommand() => loungelightOn(), () => loungeLight.Off());

            //var partyOnMacro = new MacroCommand(new ICommand[] {lightOn, stereoOnWithCd, fanOn});
            //var partyOffMacro = new MacroCommand(new ICommand[] {lightOff, stereoOff, fanOff});

            // print whats in control
            Console.WriteLine(remoteControl);

            // INVOKER Time ()           
            remoteControl.PressOnButton(0);
            remoteControl.PressOffButton(0);

            remoteControl.PressOnButton(1);
            remoteControl.PressOffButton(1);

            remoteControl.PressOnButton(2);
            remoteControl.PressOffButton(2);

            remoteControl.PressOnButton(3);
            remoteControl.PressOffButton(3);

            remoteControl.PressOnButton(4);
            remoteControl.PressOffButton(4);

            // remoteControl.PressUndoButton();

            //Console.WriteLine("--- Pushing Macro On ---");
            //remoteControl.PressOnButton(3);
            //Console.WriteLine("--- Pushing Macro Off ---");
            //remoteControl.PressOffButton(3);
            //Console.WriteLine("Hello World!");

            // }
        }
    }
}
