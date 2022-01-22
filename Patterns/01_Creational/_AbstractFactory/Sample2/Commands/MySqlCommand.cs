using System;

namespace Sample2.Commands
{
    public class MySqlCommand : ICommand
    {
        public void Insert(string command)
        {
            Console.WriteLine("Insert MySql Command: " + command);
        }
    }
}