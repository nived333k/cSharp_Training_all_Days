using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class operatorOverloading
    {
        public string str;
        public int num;

        public static operatorOverloading operator +(operatorOverloading obj1 , operatorOverloading obj2) 
        {
            operatorOverloading obj3 = new operatorOverloading();
            obj3.str = obj1.str +" "+ obj2.str;
            obj3.num = obj1.num + obj2.num;
            return obj3;

        }
    } 

    class program
    {
        static void Main()
        {
            operatorOverloading obj1 = new operatorOverloading();
            obj1.str = "Nived";
            obj1.num = 21;

            operatorOverloading obj2 = new operatorOverloading();
            obj2.str = "K";
            obj2.num = 21;

            operatorOverloading obj3 = new operatorOverloading();
            obj3 = obj1 + obj2;
            Console.WriteLine(obj3.str);
            Console.WriteLine(obj3.num);
            Console.ReadLine();
        }
    }
}
