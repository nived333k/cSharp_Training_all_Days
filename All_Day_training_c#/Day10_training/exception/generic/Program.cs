using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Program
    {
        static void Listeg()
        {
            List<int> numlist = new List<int>();
            numlist.Add(450);
            numlist.Add(45);
            numlist.Add(50);


            numlist.Sort();
            foreach (int x in numlist)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("the count is ", numlist.Count());

            List<string> names = new List<string>();
            names.Add("the darkside");
            names.Add("the mh near the tails");
            names.Add("the broken daylight");


            foreach (string words in names)
            {
                Console.WriteLine(words);
            }
            names.Sort();
            numlist.Sort();
        }

        static void dictionaryeg()
        {
            Dictionary<int, string> london = new Dictionary<int, string>();
            london.Add(1, "the chaos of the bubble rain");
            london.Add(2, "the altrustic mind of the cards");
            london.Add(3, "the melencholy side of bag ");

            foreach (int k in london.Keys)
            {
                Console.WriteLine(k);
            }

            foreach (KeyValuePair<int, string> kvp in london)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
            }

            Console.WriteLine("enter the value/key to search");
            int keys = Convert.ToInt32(Console.ReadLine());
            if (london.ContainsKey(keys))
            {
                Console.WriteLine("the key is present " + " " + london[keys]);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("enter the valid key");
                Console.ReadLine();
            }
            List<employee> dubai = new List<employee>();
            dubai.Add(new employee(101, "sara", "google"));
            dubai.Add(new employee(102, "joe", "microsoft"));

            foreach (var emp in dubai)
            {
                Console.WriteLine(emp.ToString());
                Console.ReadLine();
            }
        }





        class employee
        {
            int eid;
            string name;
            string company;


            public employee(int eid, string name, string company)
            {
                this.eid = eid;
                this.name = name;
                this.company = company;
            }

            public override string ToString()
            {
                return string.Format("employee id : "+" "+eid+ "name"+" "+name+" "+"company"+" "+ company );
            }




            class student
            {
                public dynamic total<T>(string name, int age, string std)
                {

                }
                    
            }


            static void Main(string[] args)
            {
                //Listeg();
                //Console.ReadLine();

                dictionaryeg();
                Console.ReadLine();

            }
        }
    }
}
