using System;

namespace _Adapter.Adaptee
{
    // Adaptee: nova classe e novos métodos a serem utilizados pelo Target (DbCommand)
    public class MySqlCommand
    {
        public void InsertMySql()
        {
            Console.WriteLine("Insert MySql Command");
        }

        public void UpdateMySql()
        {
            Console.WriteLine("Update MySql Command");
        }

        public void DeleteMySql()
        {
            Console.WriteLine("Delete MySql Command");
        }
    }
}