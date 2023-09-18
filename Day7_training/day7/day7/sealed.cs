using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{

     class BaseClass
    {
        public virtual void show()
        {
            Console.WriteLine("this is a base class");
        }
        
    }

    class DerivedClass : BaseClass
    {
        public sealed override void show()         //now  we can not override the derivedClass method 
        {
            Console.WriteLine("this is a derived class");
        }
    }

    //class c : DerivedClass
    //{
    //    public override void show()
    //    {
    //        Console.WriteLine("this is method of c");
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
