using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int prod = 0;
            int diff = 0;
            int div = 0;
            Program pobj = new Program();
            Program.Calculate(10, 5, out sum, out prod, out diff, out div);
        }
        public static void Calculate(int a ,int b ,out int sum , out int product , out int difference, out int division)
                
        {

            Console.WriteLine(sum = a + b);
            Console.WriteLine(product = a * b);
            Console.WriteLine(division = a / b);
            Console.WriteLine(difference = a-b);
            Console.Read();
        }
    }
}
