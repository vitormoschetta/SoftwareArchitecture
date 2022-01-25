using System;

namespace Sample2.Connections
{
    public class MySqlConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("MySql Connected");
        }
    }
}