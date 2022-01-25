using Sample1.Connections;
using Sample1.Enum;

namespace Sample1.Factories
{
    public class ConnectionFactory
    {
        public ConnectionBase GetConnection(EDataBaseType dataBaseType)
        {
            switch (dataBaseType)
            {
                case EDataBaseType.Oracle:
                    return new OracleConnection();

                case EDataBaseType.MySql:
                    return new MySqlConnection();

                default:
                    throw new System.Exception("Invalid database type");
            }
        }
    }
}