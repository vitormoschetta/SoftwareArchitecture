using System;
using Sample2.Connections;
using Sample2.Enum;
using Sample2.Factories;

namespace Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            IConnection connection = new ConnectionFactory().GetConnection(EDataBaseType.Oracle);
            connection.Connect();

            connection = new ConnectionFactory().GetConnection(EDataBaseType.MySql);
            connection.Connect();
        }
    }
}
