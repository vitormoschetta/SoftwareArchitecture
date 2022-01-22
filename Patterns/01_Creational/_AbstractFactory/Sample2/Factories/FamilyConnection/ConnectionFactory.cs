using System;
using Sample2.Connections;
using Sample2.Enums;

namespace Sample2.Factories
{
    public class ConnectionFactory : IConnectionFactory
    {
        public IConnection FactoryMethod(EDataBaseType dataBaseType)
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