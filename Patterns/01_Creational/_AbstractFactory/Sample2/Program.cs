using System;
using Sample2.Enums;
using Sample2.Factories;

namespace Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractFactory abstractFactory = new AbstractFactory(new ConnectionFactory(), new CommandFactory());

            var sqlConnection = abstractFactory.GetConnection(EDataBaseType.Oracle);

            abstractFactory.ExecuteCommand(EDataBaseType.Oracle, "insert into...");
        }
    }
}
