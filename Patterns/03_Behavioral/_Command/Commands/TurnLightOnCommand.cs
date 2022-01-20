using _Command.Lights;

namespace _Command.Commands
{
    public class TurnLightOnCommand : ICommand
    {
        private readonly IGenericLight _light;

        public TurnLightOnCommand(IGenericLight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}