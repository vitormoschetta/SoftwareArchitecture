using Sample2.Commands;
using Sample2.Enum;

namespace Sample2.Factories
{
    public interface ICommandFactory
    {
        ICommand FactoryMethod(EDataBaseType dataBaseType);
    }
}