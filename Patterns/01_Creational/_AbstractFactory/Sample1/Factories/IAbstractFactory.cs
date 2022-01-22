using Sample1.Commands;
using Sample1.Connections;
using Sample1.Enums;

namespace Sample1.Factories
{
    public interface IAbstractFactory
    {
        ICommand GetDataBaseCommand();
        IConnection GetDataBaseConnection();
    }
}