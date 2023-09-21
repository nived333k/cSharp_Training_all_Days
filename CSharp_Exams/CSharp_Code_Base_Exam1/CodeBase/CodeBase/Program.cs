using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.
            Console.WriteLine("enter a string");
            string word = Console.ReadLine();
           
            Console.WriteLine("enter the postion");
            int pos = Convert.ToInt32(Console.ReadLine());
            string newStr = "";
          
            for(int i = 0; i < word.Length; i++)
            {
                if (i!= pos)
                {
                    newStr += word[i];
                }

            }
            Console.WriteLine(newStr);
            Console.ReadLine();



 


            //2.
             mult_table();
        }


        static void mult_table()
        {
            Console.WriteLine("Enter the number : ");
            int multi = Convert.ToInt32(Console.ReadLine());
            int i=0;
            int result = 0;
            for ( i= 0; i <= 10; i++)
            {
                result = multi * i;
                Console.WriteLine($"{multi} * {i} = {result}");
            }

          //  Console.WriteLine($"{multi} * {i} = {result}");
            Console.ReadLine();
        }

    }



}
