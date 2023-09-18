using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class destructors
    {
        static void Main()
        {
            user p1 = new user("Nived",21);
            Console.WriteLine(p1.getName());
            Console.WriteLine(p1.getAge());
            //Console.ReadLine();

        }
       
    }
    class user
    {
        public string name;
        public int age;

        public user(string Name , int Age)
        {
            this.name = Name;
            this.age = Age;
        }

        public string getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return this.age;
        }
        //destructor is also a part of class and will have the class name

        ~user()
        {
            Console.WriteLine("destructor has been invoked");
        }
    }
    
}
