using Sample1.Commands;
using Sample1.Enum;

namespace Sample1.Factories
{
    public class CommandFactory
    {
        public CommandBase FactoryMethod(EDataBaseType dataBaseType)
        {
            switch (dataBaseType)
            {
                case EDataBaseType.Oracle:
                    return new OracleCommand();

                case EDataBaseType.MySql:
                    return new MySqlCommand();

                default:
                    throw new System.Exception("Invalid database type");
            }
        }
    }
}