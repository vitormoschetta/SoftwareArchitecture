using _Adapter.Adaptee;
using _Adapter.Target;

namespace _Adapter.Adapter
{
    public class DbCommandAdapter : IDbCommand
    {
        private readonly MySqlCommand _mySqlCommand;

        public DbCommandAdapter(MySqlCommand mySqlCommand)
        {
            _mySqlCommand = mySqlCommand;
        }

        public void Insert()
        {
            _mySqlCommand.InsertMySql();
        }

        public void Update()
        {
            _mySqlCommand.UpdateMySql();
        }

        public void Delete()
        {
            _mySqlCommand.DeleteMySql();
        }
    }
}