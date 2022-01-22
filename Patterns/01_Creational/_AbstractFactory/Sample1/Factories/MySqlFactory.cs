using Sample1.Commands;
using Sample1.Connections;

namespace Sample1.Factories
{
    public class MySqlFactory : IAbstractFactory
    {
        public ICommand GetDataBaseCommand()
        {
            return new MySqlCommand();
        }

        public IConnection GetDataBaseConnection()
        {
            return new MySqlConnection();
        }
    }
}