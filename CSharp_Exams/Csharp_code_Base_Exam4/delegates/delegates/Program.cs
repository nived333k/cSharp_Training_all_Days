using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{


    // here we are declaring the delegates
    delegate int Calculator(int a, int b);

    class Program
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
        

        static void Main()
        {
            Calculator calculatorapp;

            while (true)
            {
                Console.WriteLine("Calculator Menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice 1 or 2 or 3 or 4 ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice != 4)
                {
                    

                    Console.Write("Enter the first number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            calculatorapp = Addition;
                            Console.WriteLine("Result: " + calculatorapp(num1, num2));
                            break;
                        case 2:
                            calculatorapp = Subtract;
                            Console.WriteLine("Result: " + calculatorapp(num1, num2));
                            break;
                        case 3:
                            calculatorapp = Multiply;
                            Console.WriteLine("Result: " + calculatorapp(num1, num2));
                            break;
                        default:
                            Console.WriteLine("Please select 1 or 2 or 3 or 4");
                            break;
                    }

                }
                else
                {

                    break;
                }

                Console.WriteLine("thanks for using me ");
            }
        }
    }
}
