using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _ObjectOrientedProgrammingSample
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;            
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public (bool, string) Validate()
        {
            if (string.IsNullOrEmpty(Name))
            {
                return (false, "Nome do produto NÃO informado");
            }

            if (Price <= 0)
            {
                return (false, "Informe um preço válido para o produto");
            }

            return (true, "Gravado com sucesso");
        }
    }
}