using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enhancements
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAnonymousType = new
            {
                data1 = "nived",
                data2 = 2,
                data3 = true
            };
            Console.WriteLine(myAnonymousType.GetType().ToString());
           

            //literal improvements ifsc

            var lit1 = 3258_2095_5953_29;
            var lit2 = 0xeffad;
            var lit3 = 1100_0101_10100;
            Console.WriteLine(lit1+" "+lit2+" "+lit3);

            //nullable
            int? i = null;
            char? ch = null;
            Nullable<char> c = null;

            if (c.HasValue)
            {
                Console.WriteLine(c.Value);
            }
            else
            {
                Console.WriteLine("has a value");
            }
            Console.WriteLine(i+" "+ch);
            Console.ReadLine();
        }
    }
}
