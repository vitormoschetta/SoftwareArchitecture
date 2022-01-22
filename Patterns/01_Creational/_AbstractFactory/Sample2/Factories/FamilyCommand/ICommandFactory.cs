using Sample2.Commands;
using Sample2.Enums;

namespace Sample2.Factories
{
    public interface ICommandFactory
    {
        ICommand FactoryMethod(EDataBaseType dataBaseType);
    }
}