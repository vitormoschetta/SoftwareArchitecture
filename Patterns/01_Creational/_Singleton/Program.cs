using System;

namespace _Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLog = MyLog.Init();
            var myLog2 = MyLog.Init();

            var sameInstance = myLog == myLog2 ? "Sim" : "Não";

            Console.WriteLine("É a mesma instância: " + sameInstance);
        }
    }
}
