using Sample1.Enum;
using Sample1.Factories;

namespace Sample1
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
