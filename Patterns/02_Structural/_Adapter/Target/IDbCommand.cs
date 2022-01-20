namespace _Adapter.Target
{
    public interface IDbCommand
    {
        void Insert();
        void Update();
        void Delete();
    }
}