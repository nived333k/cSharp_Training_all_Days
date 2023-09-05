using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Training
{
    class TypeConversion
    {
        public static void Main()
        {
            Console.WriteLine("understanding typeConvertion");
            int i = 100;//implicit Typecasting 
            float f = i; // only lower datatype can be converted to larger data type 
            i = (int)f;//explicit typecasting
            Console.WriteLine( "the converted value"+f);
            Console.WriteLine(i);

            float f1 = 123.221f; //insted of using double we can use f as suffix .
            i = Convert.ToInt32(f1);//explicit type casting using conversion 
            // i = (int).f1;
            Console.WriteLine(i);

            //Let us convert a string to int using tryparse
            string str = "100";
            i = int.Parse(str);
            Console.WriteLine(i);

            //let us use tryparse() it uses boolean


            Console.ReadLine();


        }
    }
}
