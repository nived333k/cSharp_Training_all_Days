using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{

     abstract class person1
    {
        public abstract  int id { get; set; }
        public abstract string name { get; set; }
    }

    class student1 : person1
    {
        int student_id;
        string student_name;

        public override int id 
        {
            set
            {
                this.student_id = value;
            }
            get
            {
                return this.student_id;

            }
            
        }
        public override string name
        {
            set
            {
                this.student_name = value;
            }
            get
            {
               return  this.student_name;

            }
            
        }
    }
    class abstractprop
    {
        static void Main()
        {
            student1 neo = new student1();
            neo.id = 20030;
            neo.name = "Nived";
            Console.WriteLine(neo.id);
            Console.WriteLine(neo.name);
            Console.ReadLine();
        }
    }
}
