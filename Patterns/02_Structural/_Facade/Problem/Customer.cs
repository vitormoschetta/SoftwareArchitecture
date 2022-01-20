namespace Problem
{
    public class Customer
    {
        public Customer(string cpf, string name)
        {
            Cpf = cpf;
            Name = name;
        }

        public string Cpf { get; set; }
        public string Name { get; set; }
    }
}