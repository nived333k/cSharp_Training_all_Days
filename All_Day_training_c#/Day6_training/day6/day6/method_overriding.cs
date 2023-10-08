using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class method_overriding
    {
    }

    class parent
    {
        public virtual void print()
        {
            Console.WriteLine("this is a method of parant class ");
        }

    }

    class child : parent
    {
        public override void print()
        {
            // base.print(); // By using the base keyword we can agaig print the value of parent class in overriding .
            Console.WriteLine("this is a method of child class");
        }

    }

    class computer
    {
        static void Main()
        {
            child c1 = new child();
            c1.print();

            parent p1 = new child(); // In this case we should get the method of the parent class but insted we get the method of child class because of using
                                       // the key word virtual and override
            p1.print();

        

        }
    }
}
