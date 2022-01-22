using Sample2.Enums;

namespace Sample2.Factories
{
    public class AbstractFactory : IAbstractFactory
    {
        private ICommandFactory _commandFactory;
        private IConnectionFactory _connectionFactory;

        public AbstractFactory(IConnectionFactory connectionFactory, ICommandFactory commandFactory)
        {
            _commandFactory = commandFactory;
            _connectionFactory = connectionFactory;
        }

        public string GetConnection(EDataBaseType dataBaseType)
        {
            var concreteConnection = _connectionFactory.FactoryMethod(dataBaseType);
            return concreteConnection.GetConnection();
        }

        public void ExecuteCommand(EDataBaseType dataBaseType, string command)
        {
            var concreteCommand = _commandFactory.FactoryMethod(dataBaseType);
            concreteCommand.Insert(command);
        }
    }
}