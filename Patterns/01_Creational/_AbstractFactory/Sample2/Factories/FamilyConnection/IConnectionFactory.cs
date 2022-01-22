using Sample2.Connections;
using Sample2.Enums;

namespace Sample2.Factories
{
    public interface IConnectionFactory
    {
        IConnection FactoryMethod(EDataBaseType dataBaseType);
    }
}