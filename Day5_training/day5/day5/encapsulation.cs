using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{

    class person
    {
        private string name;
        private int age;

        public void setName(string Name)
        {
            
            if (string.IsNullOrEmpty(Name)==true)
            {
                Console.WriteLine("name is required");

            }
            else
            {
                this.name = Name;

            }
        }
        public void getName()
        {
            Console.WriteLine("your name is :"+this.name);
        }
        public void setAge(int Age)
        {
            this.age = Age;
            if (age > 0)
            {
                this.age = Age;
            }
            else
            {
                Console.WriteLine("enter a valid age");
            }
        }
        public void getAge()
        {
            Console.WriteLine("your name is :" + this.age);
        }
    }
    class encapsulation
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.setName("");
            p.getName();
            p.setAge(-21);
            p.getAge();
            Console.ReadLine();

        }
    }
}
