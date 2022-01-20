using System;
using Sample1.CreditProtectors;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Customer("12345678911", "Vitor");
            var facade = new Facade(
                new Serasa(), 
                new SPC(), 
                new Credit());

            facade.ConsultarCredito(cliente);
        }
    }
}
