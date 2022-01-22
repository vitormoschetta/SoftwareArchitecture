using System;
using System.Collections.Generic;

namespace Sample1
{
    public class FolderComponent : BaseComponent
    {
        public FolderComponent(string name)
        {
            Name = name;
        }

        public FolderComponent(string name, IList<BaseComponent> childrens = null)
        {
            Name = name;
            Childrens = new List<BaseComponent>();
            Childrens = childrens;
        }

        public FolderComponent(string name, BaseComponent children = null)
        {
            Name = name;
            Childrens = new List<BaseComponent>();
            Childrens.Add(children);
        }

        public IList<BaseComponent> Childrens { get; set; }

        public override void Print(string structure)
        {
            Console.WriteLine(structure + Name);

            foreach (var children in Childrens)
            {
                children.Print(structure + "| ");
            }
        }
    }
}