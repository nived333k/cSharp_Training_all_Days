using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box add(Box box1 , Box box2)
        {
            double newlenght = box1.Length + box2.Length;
            double newbreath = box1.Breadth + box2.Length;
            return new Box(newlenght, newbreath);
        }

        public void Display()
        {
            Console.WriteLine($"Length: {Length} ");
            Console.WriteLine($"Breadth: {Breadth} ");
        }
    }

    class Test
    {
       static void Main()
        {

            Console.WriteLine("enter length and breath of box 1");
            double len1 = Convert.ToDouble(Console.ReadLine());
            double bre1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the length and breath of box2");
            double len2 = Convert.ToDouble(Console.ReadLine());
            double bre2 = Convert.ToDouble(Console.ReadLine());

            Box box1 = new Box(len1, bre1);
            Box box2 = new Box(len2, bre2);

            Box box3 = Box.add(box1, box2);
            Console.WriteLine("result ");
            box3.Display();


            Console.ReadLine();
        }
       
    }
}
