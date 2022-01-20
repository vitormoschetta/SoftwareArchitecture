using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sample1.CreditProtectors;

namespace Sample1
{
    public class Facade
    {
        private Serasa _serasa;
        private SPC _spc;
        private Credit _credito;
        public Facade(Serasa serasa, SPC spc, Credit credito)
        {
            _serasa = serasa;
            _spc = spc;
            _credito = credito;
        }

        public void ConsultarCredito(Customer cliente)
        {
            var restricao = false;

            restricao = _spc.Consulta(cliente.Cpf);
            restricao = _serasa.Consulta(cliente.Cpf);

            if (restricao)
            {
                Console.WriteLine("Cliente com restrição...");
                return;
            }

            var limiteCredito = _credito.CheckCreditLimit(cliente.Cpf);
            Console.WriteLine("Cliente {0} possui limite de crédito no valor de: {1}", cliente.Name, limiteCredito);
        }
    }
}