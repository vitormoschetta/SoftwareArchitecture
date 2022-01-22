using System;

namespace Sample2
{
    public class FileComponent : IComponent
    {
        public FileComponent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Print(string structure)
        {
            Console.WriteLine(structure + Name);
        }
    }
}