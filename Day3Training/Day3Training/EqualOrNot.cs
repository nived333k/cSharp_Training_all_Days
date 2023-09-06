using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Training
{
    class EqualOrNot
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Enter num 1 integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num 2 integer");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1 == num2)
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
