using System;

namespace _StructuredProgrammingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var productName = "Item XPTO";
            var productPrice = 9.99m;

            var (sucess, message) = SaveProduct(productName, productPrice);

            if (sucess is false)
            {
                Console.WriteLine(message);
                return;
            }

            Console.WriteLine(message);
        }

        static (bool, string) SaveProduct(string productName, decimal productPrice)
        {
            if (string.IsNullOrEmpty(productName))
            {
                return (false, "Nome do produto NÃO informado");
            }

            if (productPrice <= 0)
            {
                return (false, "Informe um preço válido para o produto");
            }

            return (true, "Gravado com sucesso");
        }
    }
}
