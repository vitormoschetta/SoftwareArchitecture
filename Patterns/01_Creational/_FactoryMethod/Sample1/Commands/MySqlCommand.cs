using System;

namespace Sample1.Commands
{
    public class MySqlCommand : CommandBase
    {
        public override void Insert()
        {
            Console.WriteLine("Insert Mysql Command");
        }
    }
}