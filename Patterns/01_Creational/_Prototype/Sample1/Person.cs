using System;

namespace Sample1
{
    public class Person
    {
        public string School { get; set; }
        public string Name { get; set; }

        public Person(string school, string name)
        {
            School = school;
            Name = name;
        }

        public Person(Person person)
        {
            School = person.School;
        }

        public void Print()
        {            
            Console.WriteLine(School);
            Console.WriteLine(Name);
            Console.WriteLine(string.Empty);
        }

        public Person Clone(string name)
        {
            return new Person(School, name);
        }
    }
}
