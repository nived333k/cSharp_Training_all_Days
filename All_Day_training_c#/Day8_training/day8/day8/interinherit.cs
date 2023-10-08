using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    interface i1
    {
        void print();
    }
    interface i2
    {
        void print1();
    }
    interface i3 : i1 , i2
    {
        void print2();
    }
    class interinherit : i3
    {
       

        public void print()
        {
            Console.WriteLine("this is interface 1");
        }

        public void print1()
        {
            Console.WriteLine("this is interface 2");

        }

        public void print2()
        {
            Console.WriteLine("this is interface 3");

        }


        static void Main()
        {
            interinherit p = new interinherit();
            p.print();
            p.print1();
            p.print2();


            i1 interface1 = new interinherit();
            interface1.print();
            i2 interface2 = new interinherit();
            interface2.print1();
            i3 interface3 = new interinherit();
            interface3.print2();

            Console.ReadLine();


        }
    }
}
