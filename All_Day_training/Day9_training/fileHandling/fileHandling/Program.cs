using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace fileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\data.txt";//verbatim literal
            string path2 = @"D:\data\data2.txt";
            File.Copy(path, path2);
            
            if (File.Exists(path) == true)
            {
                Console.WriteLine("file is found");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("file not found ");
            }



            Console.ReadLine();
        }
    }
}
