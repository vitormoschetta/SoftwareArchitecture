using System;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var magazine1 = new Magazine("Veja");
            var magazine2 = new Magazine("Exame");

            var assinante1 = new Subscriber(magazine1, "Vitor");
            var assinante2 = new Subscriber(magazine1, "Cris");
            var assinante3 = new Subscriber(magazine2, "Riquellme");

            magazine1.PublishEdit("Ed 25");
            magazine2.PublishEdit("Ed 33");
        }
    }
}
