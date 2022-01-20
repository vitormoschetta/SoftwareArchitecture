using System;

namespace Sample2.Commands
{
    public class OracleCommand : ICommand
    {
        public void Insert()
        {
            Console.WriteLine("Insert Oracle Command");
        }
    }
}