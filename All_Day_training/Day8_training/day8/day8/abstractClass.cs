using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{

    abstract class person
    {
        public string Fname;
        public string Lname;
        public int age;
        public long phoneNo;

        public abstract void printDetails(); // this is a abstract method
    }

    class student : person
    {
        public int rollNo;
        public int fee;

        public override void printDetails()
        {
            string name = this.Fname + " " + this.Lname;
            Console.WriteLine("student name {0} ",name);
            Console.WriteLine("student age {0}", this.age);
            Console.WriteLine("student phone Number {0}",this.phoneNo);
            Console.WriteLine("student rollno is {0}",this.rollNo);
            Console.WriteLine("student fee is {0}", this.fee);
        }
    }

    class teacher : person
    {
        public string qualification;
        public int salary;
        public override void printDetails()
        {
            string name = this.Fname + " " + this.Lname;
            Console.WriteLine("Teacher name {0} ", name);
            Console.WriteLine("Teacher age {0}", this.age);
            Console.WriteLine("Teacher phone Number {0}", this.phoneNo);
            Console.WriteLine("Teacher qualification is {0}", this.qualification);
            Console.WriteLine("Teacher salary is {0}", this.salary);



        }

    }
    class abstractClass
    {
        static void Main()
        {
            student nived = new student();
            nived.Fname = "nived";
            nived.Lname = "k";
            nived.age = 21;
            nived.phoneNo = 9895622490;
            nived.rollNo = 003344;
            nived.fee = 180000;
            nived.printDetails();
            Console.WriteLine("-----------------------");

            teacher james = new teacher();
            james.Fname = "james";
            james.Lname = "G";
            james.age = 54;
            james.phoneNo = 9549395022;
            james.qualification = "M-tech computer science";
            james.salary = 500000;
            james.printDetails();

            
            Console.ReadLine();

        }
    }
}
