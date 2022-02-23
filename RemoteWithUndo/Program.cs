using System;

namespace RemoteWithUndo
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------
            // ----   First Controller Test Start  - Simple Undo

            //var remoteControl = new RemoteControl(); 

            //var loungeLight = new Light("Living Room");
            //var loungelightOn = new LightOnCommand(loungeLight);
            //var loungelightOff = new LightOffCommand(loungeLight);
            //remoteControl.SetCommand(0, loungelightOn, loungelightOff);

            //// print whats in control
            //Console.WriteLine(remoteControl);

            //// INVOKER Time ()           
            //remoteControl.PressOnButton(0);
            //remoteControl.PressOffButton(0);
            //// print whats in control
            //Console.WriteLine(remoteControl);
            //remoteControl.PressUndoButton();
            //remoteControl.PressOffButton(0);
            //remoteControl.PressOnButton(0);
            //// print whats in control
            //Console.WriteLine(remoteControl);
            //remoteControl.PressUndoButton();

            // 
            //             First Controller Test End  
            // -------------------------------------------







            // -------------------------------------------
            // ----------  Second controller Loaded - Ceiling Fan Test with Undo

            var remoteControl = new RemoteControl();
            var ceilingFan = new CeilingFan("Living Room");
            var ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);
            var ceilingFanMedCommand = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

            remoteControl.SetCommand(0, ceilingFanLowCommand, ceilingFanOffCommand);
            remoteControl.SetCommand(1, ceilingFanMedCommand, ceilingFanOffCommand);
            remoteControl.SetCommand(2, ceilingFanHighCommand, ceilingFanOffCommand);


            //// INVOKER Time ()           
            remoteControl.PressOnButton(0);
            remoteControl.PressOffButton(0);           
            Console.WriteLine(remoteControl);
            remoteControl.PressUndoButton();

            remoteControl.PressOnButton(1);
            Console.WriteLine(remoteControl);
            remoteControl.PressUndoButton();

            remoteControl.PressOnButton(2);
            Console.WriteLine(remoteControl);
            remoteControl.PressUndoButton();

            // 
            //             Second Controller Test End  
            // -------------------------------------------

        }
    }
}
