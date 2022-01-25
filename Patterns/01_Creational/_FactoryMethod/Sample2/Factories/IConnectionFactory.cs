using Sample2.Connections;
using Sample2.Enum;

namespace Sample2.Factories
{
    public interface IConnectionFactory
    {
        IConnection GetConnection(EDataBaseType dataBaseType);
    }
}