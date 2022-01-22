using System;
using Sample1.Factories;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractFactory factory = new OracleFactory();
            var connection = factory.GetDataBaseConnection();
            var command = factory.GetDataBaseCommand();
            command.Insert("insert into..");
        }
    }
}
