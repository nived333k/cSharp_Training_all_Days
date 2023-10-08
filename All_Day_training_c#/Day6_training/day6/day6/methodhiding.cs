using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{


    class parent1
    {
        public void show()
        {
            Console.WriteLine("Parent class method");
        }
    }

    class child1 : parent1
    {
        public new void show()
        {
            base.show();//now this will call the parent class method 
           // Console.WriteLine("Child class method");
        }

    }

    
    class methodhiding
    {
        static void Main()
        {
            //  child1 c = new child1();
            //c.show();//now its hiding the method of parent this is known as method hiding in c#

            // ((parent1)c).show();
            parent1 p = new child1();
            p.show();


            Console.ReadLine();
        }


    }
}
