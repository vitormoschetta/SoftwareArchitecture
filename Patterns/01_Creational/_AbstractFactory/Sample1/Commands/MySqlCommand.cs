using System;

namespace Sample1.Commands
{
    public class MySqlCommand : ICommand
    {
        public void Insert(string command)
        {
            Console.WriteLine("Insert MySql Command: " + command);
        }
    }
}