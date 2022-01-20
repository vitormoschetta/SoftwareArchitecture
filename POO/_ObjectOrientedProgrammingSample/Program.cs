using System;

namespace _ObjectOrientedProgrammingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Item XPTO", 9.99m);

            var (sucess, message) = product.Validate();

            if (sucess is false)
            {
                Console.WriteLine(message);
                return;
            }            

            var repository = new ProductRepository();
            repository.Add(product);
        }
    }
}
