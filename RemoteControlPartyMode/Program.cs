using System;

namespace RemoteControlMacroPartyMode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();

            Light light = new Light("Living Room");
            TV tv = new("Living Room");
            Stereo stereo = new("Living Room");
            Hottub hottub = new();

            LightOnCommand lightOn = new LightOnCommand(light);
            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            TVOnCommand tvOn = new TVOnCommand(tv);
            HottubOnCommand hottubOn = new HottubOnCommand(hottub);
            LightOffCommand lightOff = new LightOffCommand(light);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            TVOffCommand tvOff = new TVOffCommand(tv);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            ICommand[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
            ICommand[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);
            Console.WriteLine("--- Pushing Macro On---");
            remoteControl.PressOnButton(0);
            Console.WriteLine("--- Pushing Macro Off---");
            remoteControl.PressOffButton(0);


            Console.WriteLine("--- Pushing Macro On---");
            remoteControl.PressOnButton(0);
            Console.WriteLine("--- Pushing Undo---");
            remoteControl.PressUndoButton();
        }
    }
}