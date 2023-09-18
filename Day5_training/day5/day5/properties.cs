using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class student
    {
        private int _studentid;
        private string _name;
        private int _stubjectMark = 100;//readonly properties

        //lets create a properties
        public int studid
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("id can not be 0 or negitive");
                }
                else
                {
                    this._studentid = value;
                }
            }
            get
            {
                return this._studentid;
            }
        }

        public string  name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name can not be empty");
                }
                else
                {
                    this._name = value;
                }
            }
            get
            {
                return this._name;
            }
        }
        public int mark
        {
            get
            {
                return this._stubjectMark;
            }
        }

    }
    class people {
        //this is auto implement 
        public string first_name { get; private set; }
        public string last_name { get; private set; }

        public people(string fname , string lname)
        {
            first_name = fname;
            last_name = lname;

        }
    }

    class university {

        private static string university_name;
        private static string department_name;
        //properties
        public static   string _univerity_name
        {
            get
            {
                return university_name;
            }


            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("enter a valid name ");
                }
                else
                {
                    university_name = value;
                }
                
            }
        }

        public static string _department_name { get; set; }
    }




    class properties
    {
        static void Main()
        {
            //student s = new student();
            //s.studid = 23;
            //s.name = "Nived";
            //people p1 = new people("rahul","dravid");
            ////p1.first_name = "rahul";
            //Console.WriteLine(p1.first_name);
            //Console.WriteLine(s.name);
            //Console.WriteLine(s.mark);
            //Console.WriteLine(s.studid);
            //Console.WriteLine();
            //Console.ReadLine();

            //since we are using static we can not add new objects 

            //university u1 = new university();
            //u1._univerity_name = "cambridge";
            //Console.WriteLine(u1._univerity_name);

            //when the class is static we use the variables like this 

            university._univerity_name = "cambridge";
            Console.WriteLine("{0}",university._univerity_name);
            
        }

    }
}
