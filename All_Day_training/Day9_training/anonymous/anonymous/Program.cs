using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous
{
    public delegate int myDelegate(int num);
    class Program
    {
        //public static void Mymethod(int a)
        //{
        //    a += 10;
        //    Console.WriteLine(a);

        //}
        static void Main(string[] args)
        {
            //myDelegate obj = new myDelegate(Program.Mymethod);
            //obj.Invoke(5);
            //given below is  a anonymous function
            myDelegate obj = delegate (int a)
            {
                a += 10;
                return a;
            };


            
            Console.WriteLine(obj.Invoke(5));
            Console.ReadLine();
        }
    }
}
