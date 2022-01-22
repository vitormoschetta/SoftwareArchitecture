using Sample1.Commands;
using Sample1.Connections;

namespace Sample1.Factories
{
    public class OracleFactory : IAbstractFactory
    {
        public ICommand GetDataBaseCommand()
        {
            return new OracleCommand();
        }

        public IConnection GetDataBaseConnection()
        {
           return new OracleConnection();
        }
    }
}