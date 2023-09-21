using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous
{
    class finance
    {
        private readonly employeeSeparator employeeSeparator; 
        public finance(employeeSeparator employeeSeparator)
        {
            this.employeeSeparator = employeeSeparator;
            employeeSeparator.empseperated += empsepEventHandler;
        }
        public void empsepEventHandler()
        {
            Console.WriteLine("finance department");
            Console.ReadLine();
        }
    }
}
