using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concession;

namespace ConsessionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name ");
            string Name = Console.ReadLine();

            Console.WriteLine("enter your age");
            int Age = Convert.ToInt32(Console.ReadLine());

            Concession.conscession calculator = new Concession.conscession
            {
                name = Name,
                age = Age
            };
            calculator.calculateConsession();
            Console.ReadLine();


        }
    }
}
