using System;

namespace Sample1.Commands
{
    public class OracleCommand : ICommand
    {
        public void Insert(string command)
        {
            Console.WriteLine("Insert Oracle Command: " + command);
        }
    }
}