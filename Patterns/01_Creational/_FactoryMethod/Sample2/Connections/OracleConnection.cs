using System;

namespace Sample2.Connections
{
    public class OracleConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Oracle Connected");
        }
    }
}