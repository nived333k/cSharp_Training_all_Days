using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    public delegate void calculation2(int a, int b);
    class program
    {
        public static void display()
        {
            Console.WriteLine("this is a display method");
        }
        public static void addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("the sum is {0}", result);
        }
        public static void substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("the sub is {0}", result);
        }
        public static void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("the product is {0}", result);
        }
        public static void division(int a, int b)
        {
            float result = a / b;
            Console.WriteLine("the div values is  {0}", result);
        }
    }
    class multicasDelegate
    {
        static void Main()
        {
            calculation2 mult = new calculation2(program.addition);
            
            mult += program.substraction;//now both the method have been added addition and subtraction
            mult += program.division;
            mult += program.multiplication;
            mult -= program.division;//when we use the -= one of the method will be removed
            mult(100, 50);
            Console.ReadLine();

        }

    }
}
