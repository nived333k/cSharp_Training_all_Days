using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{


     abstract class student 
    {
        public string  stud_name { get; set; }
        public int stud_id { get; set; }
        public int stud_grade { get; set; }

        public student(string student_name , int student_id , int student_grade)
        {
             stud_name = student_name;
             stud_id  = student_id;
             stud_grade = student_grade;

        }
        public abstract bool isPassed(int student_grade);

    }

    class undergrads:student
    {
        public undergrads(string student_name , int student_id  , int student_grade) : base(student_name,student_id,student_grade)
        {

        }
        public override bool isPassed(int student_grade)
        {
            return student_grade > 70;
        }

    }

    class graduate : student 
    {
        public graduate(string student_name, int student_id, int student_grade) : base(student_name, student_id, student_grade)
        {

        }
        public override bool isPassed(int student_grade)
        {
            return stud_grade > 80;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            student ungrad = new undergrads("Nived",1033385,80);
            Console.WriteLine($"{ungrad.stud_name} has passed {ungrad.isPassed(ungrad.stud_grade)}");
            student grad = new graduate("NIved", 1033385, 60);
            Console.WriteLine($"{grad.stud_name} has passed {grad.isPassed(grad.stud_grade)}");
            Console.ReadLine();

        }
    }
}
