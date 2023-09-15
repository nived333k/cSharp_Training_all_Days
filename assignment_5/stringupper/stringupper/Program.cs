using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using noofoccurrence;
namespace stringupper
{
    internal class stringupper
    {
        

        static void display(string firstname , string lastname)
        {
            Console.WriteLine(firstname.ToUpper());
            Console.WriteLine(lastname.ToUpper());
            
        }



        static void Main(string[] args)
        {

            Console.WriteLine("enter first name");
            string firstname = Console.ReadLine();

            Console.WriteLine("enter the lastname");
            string lastname = Console.ReadLine();

            display(firstname , lastname);

            Console.ReadLine();

           


        }
    }
}
