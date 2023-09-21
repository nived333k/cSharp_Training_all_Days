using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9
{
    class compare
    {
        static void Main(string[] args)
        {
            string[] fruits = { "orange", "banana", "apple", "mango" };
            Array.Sort(fruits);
            foreach(string s in fruits)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }


    }

    class student {
        public string name { get; set; } 
        public void comparestudentsName()
        {

            // Object Initilization
            //we dont need a constructor to create an object we can use object Initilization
            student[] studarray = new student[]
            {
                new student(){name="OpenAI"},
                new student(){name="Ashwin"},
                new student(){name ="arunanan"}
            
            };
            Array.Sort(studarray);
        }
        public int compareTo(object obj)
        {
            student sobj = obj as student(); //typecasting object to student object 
        }



    }

}
