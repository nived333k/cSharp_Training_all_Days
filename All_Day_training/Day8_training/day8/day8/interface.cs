using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    interface Iemployee
    {
        void show();

    }


    class PartTimeEmployees : Iemployee
    {
        public void show()
        {
            Console.WriteLine("this is a method of Iemployee interface");
        }
    }
    class @interface
    {
        static void Main(string[] args)
        {
            PartTimeEmployees pte = new PartTimeEmployees();
            pte.show();
        }
    }
}
