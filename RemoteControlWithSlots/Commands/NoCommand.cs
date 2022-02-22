namespace RemoteControlWithSlots
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            // Do nothing.
        }

        public void Undo()
        {
            // Do nothing.
        }
    }
}
