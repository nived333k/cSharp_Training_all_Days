using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //write and writeLine :- in write output is in one line where as in writeLine its in new line.
            //Console.WriteLine("hello");
            //Console.Write("hi");
            //Console.WriteLine("  Hola");
            //Console.ReadLine();
            //console. is a part of using system.


            Console.WriteLine("Enter your First name ");
            string FName = Console.ReadLine();
            
            Console.WriteLine("Your name is "+FName);//Concatenation
            Console.WriteLine("Your name is {0}",FName);//Placeholder
            Console.WriteLine("Enter your last name");
            string Lname = Console.ReadLine();
            Console.WriteLine("Your Frist name is {0} and your Last name is {1}",FName,Lname);
            // String interpolation

            Console.WriteLine($"your First name is {FName} and your last name is {Lname}");
            MyClass.myFunction();
            func2();
            Ternary.Terfun();
            Console.ReadLine();

            
        }
        static void func2()
        {
            Console.WriteLine("this is function 2 ");
            Console.WriteLine("Enter your age");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"your age is {myAge} ");
            Console.WriteLine( "Min value = {0}",int.MinValue);
            Console.WriteLine("Max value = {0}",int.MaxValue);

        }



        class MyClass
        {
            public static void myFunction()
            {
                Console.WriteLine("we are discussing functions ");
                Console.ReadLine();
            }
        }

        class Ternary {
             public static void Terfun()
            {
                Console.WriteLine("understanding ternary functions");
                int num = 10;
                bool b;
                //if (num == 10)
                //{
                //    b = true;
                //}
                //else
                //{
                //    b = false;
                //}
                //Console.WriteLine("the correct answer is "+b);
                //Better way to this program is ternary
                b = num == 10 ? true : false;
                Console.WriteLine("the correct answer is " + b);
            }
        }

    }
}
