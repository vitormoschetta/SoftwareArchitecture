using Sample2.Enums;

namespace Sample2.Factories
{
    public interface IAbstractFactory
    {
        string GetConnection(EDataBaseType dataBaseType);
        void ExecuteCommand(EDataBaseType dataBaseType, string command);
    }
}