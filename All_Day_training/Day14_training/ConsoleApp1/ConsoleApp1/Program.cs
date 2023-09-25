using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class employee
    {
        //auto property initializer
        public string Eid { get; } = "100234";//setting 
        public double salary { get; } = 45000;//setting 

        public string Empname { get; private set; }
        public string dept  { get; protected set; }

        public void enamesetting()
        {
            Empname = "sonu";
            dept = "HR";

        }
    }
    class Program : employee
    {


        static void Main(string[] args)
        {
            employee e = new employee();
            Program p = new Program();

            p.dept = "finance";
            e.enamesetting();   
            Console.WriteLine("{0}  , {1}  , {2}",e.Eid , e.Empname , e.dept);
            Console.ReadLine();
        }
    }
}
