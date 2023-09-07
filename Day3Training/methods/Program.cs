using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void greet(string name)
        {
            Console.WriteLine("good morning"+ name);
            Console.ReadLine();
        }

        static int Avg(int a , int b , int c)
        {
            int sum = a + b + c;
            return sum;
        } 
        static void Main(string[] args)
        {
            
            float average = Avg(3, 3, 3);
            Console.WriteLine("the average is "+average);
            Console.ReadLine();
            


        }
    }
}
