using System;

namespace Sample2.Commands
{
    public class MySqlCommand : ICommand
    {
        public void Insert()
        {
            Console.WriteLine("Insert MySql Command");
        }
    }
}