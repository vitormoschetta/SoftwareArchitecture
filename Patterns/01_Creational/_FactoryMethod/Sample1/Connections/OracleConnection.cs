using System;

namespace Sample1.Connections
{
    public class OracleConnection : ConnectionBase
    {
        public override void Connect()
        {
            Console.WriteLine("Oracle Connected");
        }
    }
}