using System;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Harvard", "Vitor");
            person1.Print();

            // Ao usar o método 'Clone', passamos apenas o nome do 'Person', uma vez que ele faz parte da mesma escola
            // Ou seja, estamos reaproveitando um valor que já está em memória.
            // Esse exemplo é muito simples. Agora imagine o caso em que os valores em memórias a serem copiados do protótipo
            // seja dezenas, centenas, milhares?
            var person2 = person1.Clone("Christian");
            person2.Print();

            Console.WriteLine(person1 == person2);
        }
    }
}
