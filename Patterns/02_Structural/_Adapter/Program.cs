using _Adapter.Adaptee;
using _Adapter.Adapter;
using _Adapter.Target;

namespace _Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Target
            var dbCommand = new DbCommand();
            dbCommand.Insert();

            // Adaptee
            var mySqlCommmand = new MySqlCommand();
            //mySqlCommmand.InsertMySql();  <-- o contrato IDbCommand usa um método 'Insert'

            // Adapter
            var dbcommandAdapter = new DbCommandAdapter(new MySqlCommand());
            dbcommandAdapter.Insert();

            
        }
    }
}
