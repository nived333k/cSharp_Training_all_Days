﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateofBirth { get; set; }

        public Student(int id, string name, string dateofbirth)
        {
            Id = id;
            Name = name;
            DateofBirth = dateofbirth;
        }


        public class Info
        {
            public void Display(Student student)
            {
                Console.WriteLine("student id :" + student.Id);
                Console.WriteLine("student name:" + student.Name);
                Console.WriteLine("student dateofbirth:" + student.DateofBirth);
                Console.ReadLine();

            }
        }

        class app
        {
            static void Main()
            {
                app a = new app();
                a.scenario1();
                a.scenario2();


            }
            void scenario1()
            {
                //Student s1 = new Student(100,"Nived",new DateTime(2001,12,20));
                //Info info1 = new Info();
                //info1.Display(s1);
                //Student s2 = new Student(101, "VVK", new DateTime(2001, 8, 26));
                //Info info2 = new Info();
                //info2.Display(s2);
                Console.WriteLine("     This is scenario 1");
                Console.WriteLine("Enter the number of students");
                int noofstudents = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < noofstudents; i++)
                {
                    Console.WriteLine($"enter the details of student {i + 1}");
                    Console.WriteLine("student id");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("student name ");
                    string name = Console.ReadLine();
                    Console.WriteLine("date of birth");
                    string dob = Console.ReadLine();

                    Student stud = new Student(id, name, dob);
                    Info info = new Info();
                    info.Display(stud);

                }
            }

            void scenario2()
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("     This is scenario 2");
                Console.WriteLine("Enter the number of students");
                int noofstudents = Convert.ToInt32(Console.ReadLine());

                Student[] student = new Student[noofstudents];
                Info info = new Info();

                for (int i = 0; i < noofstudents; i++)
                {
                    Console.WriteLine($"enter the details of student {i + 1}");
                    Console.WriteLine("student id");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("student name ");
                    string name = Console.ReadLine();
                    Console.WriteLine("date of birth");
                    string dob = Console.ReadLine();

                    student[i] = new Student(id, name, dob);


                }

                foreach (Student std in student)
                {
                    info.Display(std);

                }

            }
        }
    }
}
