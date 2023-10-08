using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous
{
    //public delegate int delegate1(int x, int y, int z);
    //public delegate void delegate2(int x, int y, int z);
    //public delegate bool delegate3(string str); 
    class delegates2
    {
        public static int addNum(int x , int y , int z)
        {
            return x + y + z;
        }

        public static void addnum2(int x ,int y , int z)
        {
            Console.WriteLine(x+y+z);
        }
        public static bool checklength(string str)
        {
            if (str.Length > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Main()
        {
            //delegate1 obj1 = new delegate1(delegates2.addNum);
            //Console.WriteLine(obj1.Invoke(2, 3, 4));

            //delegate2 obj2 = new delegate2(delegates2.addnum2);
            //obj2.Invoke(23, 32, 4);

            //delegate3 obj3 = new delegate3(delegates2.checklength);
            //Console.WriteLine(obj3.Invoke("nivedk"));

            Func<int, int, int, int> obj1 = addNum;
            int result = obj1.Invoke(2, 3, 4);
            Console.WriteLine(result);
            Console.ReadLine();


            Action<int, int, int> obj2 = addnum2;
            obj2.Invoke(34, 55, 67);
            Console.ReadLine();

            Predicate<string> obj3 = checklength;
            Console.WriteLine(obj3.Invoke("nivedk"));
            Console.ReadLine();
             


        }
    }
}
