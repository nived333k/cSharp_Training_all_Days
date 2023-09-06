using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one number);
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= 0)
            {
                Console.WriteLine("Positive");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Negative");
                Console.ReadLine();
            }

        }
    }
}
