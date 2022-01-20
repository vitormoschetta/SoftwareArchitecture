using System;

namespace Sample1.Commands
{
    public class OracleCommand : CommandBase
    {
        public override void Insert()
        {
            Console.WriteLine("Insert Oracle Command");
        }
    }
}