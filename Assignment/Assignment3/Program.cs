using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an operand");
            string opr = Console.ReadLine();
            Console.WriteLine("Enter integer 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (opr == "+")
            {
                Console.WriteLine("the sum is"+(num1+num2));
                Console.ReadLine();

            }
            else if (opr == "-")
            {
                Console.WriteLine("the diff is"+(num1-num2));
                Console.ReadLine();

            }
            else if(opr == "*")
            {
                Console.WriteLine("the prod is" + (num1 * num2));
                Console.ReadLine();


            }
            else
            {
                Console.WriteLine("the div is" + (num1 / num2));
                Console.ReadLine();

            }

        }
    }
}
