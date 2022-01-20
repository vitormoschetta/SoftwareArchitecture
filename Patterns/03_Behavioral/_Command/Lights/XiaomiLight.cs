using System;

namespace _Command.Lights
{
    public class XiaomiLight : IGenericLight
    {
        public void TurnOff()
        {
            Console.WriteLine("A luz Xiaomi está desligada");
        }

        public void TurnOn()
        {
            Console.WriteLine("A luz Xiaomi está ligada");
        }
    }
}