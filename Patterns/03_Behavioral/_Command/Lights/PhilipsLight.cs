using System;

namespace _Command.Lights
{
    public class PhilipsLight : IGenericLight
    {
        public void TurnOff()
        {
            Console.WriteLine("A luz Philips está desligada");
        }

        public void TurnOn()
        {
            Console.WriteLine("A luz Philips está ligada");
        }
    }
}