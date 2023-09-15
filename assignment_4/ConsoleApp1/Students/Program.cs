using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
     class student
    {

        public string rollno;
        public string name;
        public string Class;
        public string sem;
        public string branch;
        public int[] marks = new int[5]; // for marks of 5 subject


        //lets create a constructor
        //constructor should have the same class name

        public student(string rollno , string name , string Class , string sem , string branch  )
        {
            this.rollno = rollno;
            this.name = name;
            this.Class = Class;
            this.sem = sem;
            this.branch = branch;



        }
        //method getmark()

        public void getMark()
        {
            Console.WriteLine("enter the marks for all 5 subjects");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("enter"+(i+1)+"marks");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // create a function to calculate average 

        public double calAvg()
        {
            double totalmarks = 0;
            for(int i=0; i<marks.Length; i++)
            {
                totalmarks = totalmarks + marks[i];
            }
            return totalmarks / 5;
        }

        public void displayReslt()
        {
            double averageMarks = calAvg();

            for(int i=0; i<marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("mark less than 35 : failed");
                    Console.ReadLine();
                    break;
                }
               else  if (marks[i] > 35 && averageMarks < 50)
                {
                    Console.WriteLine("mark is greater than 35 but average is less than 50 :  failed");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("when all marke greater than 35 and average greater than 50 : passed");
                    Console.ReadLine();
                    break;
                }
            }


            //for (int i = 0; i < marks.Length; i++)
            //{
            //    if(marks[i] > 35 && averageMarks < 50)
            //    {
            //        Console.WriteLine("mark is greater than 35 but average is less than 50 :  failed");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("when all marke greater than 35 and average greater than 50 : passed");
            //        Console.ReadLine();
            //    }
            //}
        }

        public void displaydata()
        {
            Console.WriteLine($"roll no {rollno} \n name {name} \n Class {Class} \n sem {sem} \n branch {branch} \n marks ");
            for(int i=0; i < marks.Length; i++)
            {
                Console.WriteLine($"{   marks[i]    }");

            }
            Console.ReadLine();

        }


        static void Main(string[] args)
        {
            student stud1 = new student("1033385", "nived k ", "2", "b","ise");
            stud1.getMark();
            stud1.displayReslt();
            stud1.displaydata();

        }
    }
}
