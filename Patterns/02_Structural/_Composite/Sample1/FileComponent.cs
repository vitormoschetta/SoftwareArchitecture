using System;

namespace Sample1
{
    public class FileComponent : BaseComponent
    {
        public FileComponent(string name)
        {
            Name = name;
        }

        public override void Print(string structure)
        {
            Console.WriteLine(structure + Name);
        }
    }
}