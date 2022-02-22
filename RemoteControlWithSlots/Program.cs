using System;

namespace RemoteControlWithSlots
{
    class Program
    {
        static void Main(string[] args)
        {
              var remoteControl = new RemoteControl();

            var loungeLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen Room");
            var ceilingFan = new CeilingFan("Living Room");
            var garageDoor = new GarageDoor("Garage");
            var stereo = new Stereo("Living Room");



            var loungelightOn = new LightOnCommand(loungeLight);
            var loungelightOff = new LightOffCommand(loungeLight);
            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);




            var stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            var fanOn = new CeilingFanOnCommand(ceilingFan);
            var fanOff = new CeilingFanOffCommand(ceilingFan);

            //var partyOnMacro = new MacroCommand(new ICommand[] {lightOn, stereoOnWithCd, fanOn});
            //var partyOffMacro = new MacroCommand(new ICommand[] {lightOff, stereoOff, fanOff});

            //remoteControl.SetCommand(0, lightOn, lightOff);
            //remoteControl.SetCommand(1, stereoOnWithCd, stereoOff);
            //remoteControl.SetCommand(2, fanOn, fanOff);
            //remoteControl.SetCommand(3, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);

            remoteControl.PressOnButton(0);
            remoteControl.PressOffButton(0);
           // remoteControl.PressUndoButton();

            Console.WriteLine("--- Pushing Macro On ---");
            remoteControl.PressOnButton(3);
            Console.WriteLine("--- Pushing Macro Off ---");
            remoteControl.PressOffButton(3);
            Console.WriteLine("Hello World!");
        }
    }
}
