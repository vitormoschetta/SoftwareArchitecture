using System;
using Problem.CreditProtectors;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var spc = new SPC();
            var serasa = new Serasa();
            var credito = new Credit();

            var customer = new Customer("12345678911", "Vitor");

            var restriction = false;

            restriction = spc.Consulta(customer.Cpf);
            restriction = serasa.Consulta(customer.Cpf);

            if (restriction)
            {
                Console.WriteLine("Cliente com restrição...");
                return;
            }

            var limiteCredito = credito.CheckCreditLimit(customer.Cpf);
            Console.WriteLine("customer {0} possui limite de crédito no valor de: {1}", customer.Name, limiteCredito);

            /*
            veja a bagunça e o acoplamento que ficou o código acima. O objetivo do Facade/Fachada é limpar isso, abstraindo 
            as operações em um nível mais alto para o usuário.           
            */
        }
    }
}
