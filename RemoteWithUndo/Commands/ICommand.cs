namespace RemoteWithUndo
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
