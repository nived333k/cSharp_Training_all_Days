using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    class manAndwomen
    {
        public void show1()
        {
            Console.WriteLine("this is a method of manAndwomen");
        }
    }

    interface Hisduty
    {
        void show2();
    }
    interface Herduty
    {
        void show3();
    }
    class professor : manAndwomen , Hisduty , Herduty
    {
        public void show2()
        {
            Console.WriteLine("this is a method of interface");
        }
        public void show3()
        {
            Console.WriteLine("this is a method of inetrface 2");
        }

    }


    class multipleInheritance
    {
        static void Main()
        {
            professor nived = new professor();
            nived.show1();
            nived.show2();
            nived.show3();
            Console.ReadLine();
        }
    }
}
