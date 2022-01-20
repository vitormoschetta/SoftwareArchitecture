using System;
using Sample2.Enum;
using Sample2.Factories;

namespace Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlCommand = new CommandFactory().FactoryMethod(EDataBaseType.Oracle);
            sqlCommand.Insert();

            sqlCommand = new CommandFactory().FactoryMethod(EDataBaseType.MySql);
            sqlCommand.Insert();
        }
    }
}
