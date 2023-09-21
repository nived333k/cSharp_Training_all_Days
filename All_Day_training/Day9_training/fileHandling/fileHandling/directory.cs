using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileHandling
{
    class directory
    {
        static void Main(string[] args)
        {
            string path = @"D:\myDirectory";
            DirectoryInfo dir = new DirectoryInfo(path);
            dir.Create();
            Console.WriteLine("directory created ");
            Console.ReadLine();
        }


    }
}
