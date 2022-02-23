using System.Text;

namespace RemoteControlMacroPartyMode
{
    public class RemoteControl
    {
        private readonly ICommand[] _offCommands;
        private readonly ICommand[] _onCommands;
        private ICommand _undoCommand;

        public RemoteControl()
        {
            var noCommand = new NoCommand();
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            for (var i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void PressOnButton(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void PressOffButton(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void PressUndoButton()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("\n---- Remote Control ----\n");

            for (var i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append("[slot ")
                    .Append(i)
                    .Append("] ")
                    .Append(_onCommands[i].GetType().Name)
                    .Append("\t\t")
                    .Append(_offCommands[i].GetType().Name)
                    .Append('\n');
            }

            stringBuilder.Append("[undo] ")
                .Append(_undoCommand.GetType().Name)
                .Append('\n');

            return stringBuilder.ToString();
        }
    }
}
