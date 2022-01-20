using System;

namespace Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a senha");
            string senha = Console.ReadLine();
            var salt = Salt.Create();
            var hash = Hash.Create(senha, salt);

            Console.WriteLine($"Hash: {hash}");
            //Console.WriteLine($"Salt []byte: {salt}");
            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");



            Console.WriteLine("Entre com a mesma senha");
            senha = Console.ReadLine();
            salt = Salt.Create();
            hash = Hash.Create(senha, salt);

            Console.WriteLine($"Hash: {hash}");
            //Console.WriteLine($"Salt []byte: {salt}");
            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");
        }
    }
}
