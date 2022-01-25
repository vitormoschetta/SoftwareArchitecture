using Sample1.Enum;
using Sample1.Factories;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlCommand = new ConnectionFactory().GetConnection(EDataBaseType.Oracle);
            sqlCommand.Connect();

            sqlCommand = new ConnectionFactory().GetConnection(EDataBaseType.MySql);
            sqlCommand.Connect();
        }
    }
}
