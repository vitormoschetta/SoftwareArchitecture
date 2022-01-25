using System;

namespace Sample1.Connections
{
    public class MySqlConnection : ConnectionBase
    {
        public override void Connect()
        {
            Console.WriteLine("MySql Connected");
        }
    }
}