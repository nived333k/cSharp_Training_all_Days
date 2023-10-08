using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{

    class overloading 
    {
        public void add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void add(int a ,int b)
        {
            
            int c = a + b;
            Console.WriteLine(c);
        }
        public void add(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }
        public void add(float a ,float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }


    }
    class polymorphism
    {
        static void Main(string[] args)
        {
            overloading add1 = new overloading();
            //add1.add(21,45);
            add1.add(2.5f,3.4f);
            add1.add("Nived", "K");

        }
    }
}
