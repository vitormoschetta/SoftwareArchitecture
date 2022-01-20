using System;

namespace Sample1.CreditProtectors
{
    public class Serasa
    {
        public bool Consulta(string cpf)
        {
            Console.WriteLine("SERASA - consultando CPF {0}...", cpf);  
            return false;                   
        }
    }
}