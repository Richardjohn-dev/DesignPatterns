namespace RemoteControlMacroPartyMode
{
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
        public void Undo()
        {
            _garageDoor.Down();
        }
    }
}
