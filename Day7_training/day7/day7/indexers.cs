using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{

    class employee 
    {
        private int[] age = new int[3];

        // lets create a indexer
        public int this[int index]
        {
            set
            {
                if (index>=0 && index<age.Length) {
                    if (value > 0)
                    {
                        age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid age");
                    }


                }
                else
                {
                    Console.WriteLine("the index value is invalid ");
                }
            
            }
            get
            {
                return age[index];
            
            }
            
        }
    }

    class indexers
    {
        static void Main()
        {
            employee emp = new employee();
            emp[0] = -5;
           
            Console.WriteLine(emp[0]);
            Console.ReadLine();
        }
    }
}
