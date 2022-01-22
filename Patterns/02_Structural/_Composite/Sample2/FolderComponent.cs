using System;
using System.Collections.Generic;

namespace Sample2
{
    public class FolderComponent : IComponent
    {
        public FolderComponent(string name)
        {
            Name = name;
        }

        public FolderComponent(string name, IList<IComponent> childrens = null)
        {
            Name = name;
            Childrens = new List<IComponent>();
            Childrens = childrens;
        }

        public FolderComponent(string name, IComponent children = null)
        {
            Name = name;
            Childrens = new List<IComponent>();
            Childrens.Add(children);
        }

        public string Name { get; set; }
        public IList<IComponent> Childrens { get; set; }

        public void Print(string structure)
        {
            Console.WriteLine(structure + Name);

            foreach (var children in Childrens)
            {
                children.Print(structure + "| ");
            }
        }
    }
}