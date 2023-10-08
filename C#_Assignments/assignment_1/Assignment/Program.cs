using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num 1 integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num 2 integer");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
                Console.ReadLine();
            }
        }
    }
}
