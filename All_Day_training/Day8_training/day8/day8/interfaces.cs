using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    interface Iemployee
    {
        //we can not declare instance or static variable in an injterface
        void show(); //by default its public and abstract normally it will be private

    }

    class partTimeEmp : Iemployee
    {
        public void show()
        {
            Console.WriteLine("this is a method of Iemployee interface");
        }
    }
    class interfaces
    {
        static void Main(string[] args)
        {
            partTimeEmp pte = new partTimeEmp();
            pte.show();
            Console.ReadLine();

        }
    }
}
