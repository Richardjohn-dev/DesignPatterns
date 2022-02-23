namespace RemoteControlMacroPartyMode
{
    public class CeilingFanOffCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private FanSpeed _previousSpeed;
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _previousSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Off();
        }
        public void Undo()
        {
            switch (_previousSpeed)
            {
                case FanSpeed.Off:
                    _ceilingFan.Off();
                    break;

                case FanSpeed.Low:
                    _ceilingFan.Low();
                    break;

                case FanSpeed.Medium:
                    _ceilingFan.Medium();
                    break;

                case FanSpeed.High:
                    _ceilingFan.High();
                    break;

                default:
                    _ceilingFan.Off();
                    break;
            }
        }
    }
}
