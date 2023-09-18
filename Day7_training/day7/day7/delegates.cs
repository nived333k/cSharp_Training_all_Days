using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//single cast delegate - only point to one method
//multiple delegate - there will be multiple delegates and multiple method
namespace day7
{
    public delegate void calculation(int a ,int b);
    public delegate void show();
    class delegates
    {
        public static void display()
        {
            Console.WriteLine("this is a display method");
        }
        public static void addition(int a , int b)
        {
            int result = a + b;
            Console.WriteLine("the sum is {0}",result);
        }
        public static void substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("the sub is {0}",result);
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

    class value
    {
        static void Main()
        {
            calculation cal = new calculation(delegates.addition);
            cal.Invoke(3,4);//we can either use the invoke method by creating different objects
            cal = delegates.substraction;//or we can use this method where one object can use all the method
            cal(3, 2);
            
            cal = delegates.multiplication;
            cal(4, 5);
            cal = delegates.division;
            cal(50, 5);
            show obj = new show(delegates.display);//here we are using multiple delegates
            obj();
            Console.ReadLine();

        }
    
    
    }

}
