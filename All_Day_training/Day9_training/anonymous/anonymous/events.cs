using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous
{
    class employeeSeparator { 


        public delegate void empsepEventHandler();
        public event empsepEventHandler empseperated;
        public void seperate()
        {
            if(empseperated != null)
            {
                empseperated();
            }
            

        }
    }
    class events
    {
        static void Main(string[] args)
        {
            employeeSeparator employeeSeparator = new employeeSeparator();
            employeeSeparator.seperate();
            Console.ReadLine();
        }
    }
}
