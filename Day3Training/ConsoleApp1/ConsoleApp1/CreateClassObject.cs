using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CreateClassObject
    {
         public static void Main(string[] args)
        {
            CreateClassObject cobj = new CreateClassObject();
            
            CreateClassObject nived = new CreateClassObject();
            nived.info();

            //Console.WriteLine("the sum of the vaues are "+ cobj.add(2, 4));
            //cobj.esakki();

           // Console.ReadLine();
        }
        

        public  int  add(int a , int b)
        {
            return a + b;
        }

        public  void esakki()
        {
            
            
            Console.WriteLine("Emotional damage is my Vibe!!!!");

        }
        public  void info()
        {
            
            Console.WriteLine("enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("your age ");
            int age = Convert.ToInt32(Console.Read());
            Console.WriteLine( "your emp id");
            int color = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("color is:", +color);
            Console.WriteLine($"Your employee information is {name} your age is {age} your emp_no {color}");
            Console.ReadLine();
        }

    }
}
