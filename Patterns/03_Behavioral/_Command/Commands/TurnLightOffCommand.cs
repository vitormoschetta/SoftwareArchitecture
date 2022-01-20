using System;
using _Command.Lights;

namespace _Command.Commands
{
    public class TurnLightOffCommand : ICommand
    {
        private IGenericLight _light;

        public TurnLightOffCommand(IGenericLight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}