using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDll;
namespace Day1_Training
    //understanding assembly
    //we add references for accessing a dll file
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine(obj.Method());
            Console.WriteLine("Understanding assembly");
            Console.WriteLine("Assembly is a precompiled .net code which can be run by the CLR");
            Console.Read();
            
            
        }
    }
}
