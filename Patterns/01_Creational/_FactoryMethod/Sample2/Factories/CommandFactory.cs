using Sample2.Commands;
using Sample2.Enum;

namespace Sample2.Factories
{
    public class CommandFactory : ICommandFactory
    {
        public ICommand FactoryMethod(EDataBaseType dataBaseType)
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