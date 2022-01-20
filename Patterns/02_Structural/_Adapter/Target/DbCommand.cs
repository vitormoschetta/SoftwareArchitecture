using System;

namespace _Adapter.Target
{
    // Target: a classe usada por padrão
    public class DbCommand : IDbCommand
    {
        public void Insert()
        {
            Console.WriteLine("Insert Command");
        }

        public void Update()
        {
            Console.WriteLine("Update Command");
        }

        public void Delete()
        {
            Console.WriteLine("Delete Command");
        }
    }
}