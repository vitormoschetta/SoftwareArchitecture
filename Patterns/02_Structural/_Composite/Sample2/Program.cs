using System.Collections.Generic;

namespace Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            var file1 = new FileComponent("File1.txt");
            var file2 = new FileComponent("File2.txt");
            var file3 = new FileComponent("File3.txt");
            var file4 = new FileComponent("File4.txt");

            var folder1 = new FolderComponent("net5", new List<IComponent> { file1, file2, file3, file4 });
            var folder2 = new FolderComponent("dotnet", folder1);
            var folder3 = new FolderComponent("Program Files", folder2);

            folder3.Print("");
        }
    }
}
