using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caseStudy1
{
    class Student
    {
        public int stdid { get; set; }

        public string stdname { get; set; }

        public string stddateofbirth { get; set; }

        public Student(int id, string name, string dateofbirth)
        {
            stdid = id;
            stdname = name;
            stddateofbirth = dateofbirth;

        }
    }

    class info
    {
        public void display(Student student)
        {
            Console.WriteLine("your name is {0} ",student.stdname);
            Console.WriteLine("your id is {0} ",student.stdid);
            Console.WriteLine("your dob is {0}",student.stddateofbirth);

        }
    }

    class app
    {
        static void Main()
        {
            app.scenario1();
            app.scenario2();
            Console.ReadLine();

        }

        static void scenario1()
        {
            info info = new info();

            Student student1 = new Student(1, "nived", "20-12-2001");
            Student student2 = new Student(2, "esakki", "23-4-2001");
            info.display(student1);
            info.display(student2);
        }
        static void scenario2()
        {
            info info = new info();

            Student[] students = new Student[2];
            students[0] = new Student(3, "jake", "24-5-2000");
            students[1] = new Student(4, "logan", "03-7-2003");

            foreach(Student stud in students)
            {
                info.display(stud);
            }
        }
    }

}
