using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    class abstraction
    {
        public int empid;
        public string name;
        public double grosspay;
        double taxDeduction = 0.1;
        double netSalary;

        public abstraction(int eid, string ename, double Egrosspay)
        {
            this.empid = eid;
            this.name = ename;
            this.grosspay = Egrosspay;

        }

        void calculateSalary()
        {
            if (grosspay >= 30000)
            {
                netSalary = grosspay - (taxDeduction * grosspay);
                Console.WriteLine("yourn salary is {0}", netSalary);
            }
            else
            {
                Console.WriteLine("your salary is {0}", grosspay);
            }
        }
        public void showemployeesalary()
        {
            this.calculateSalary();
        }
    }

    class employee
    {
        static void Main()
        {
            abstraction emp1 = new abstraction(21, "nived", 31000);
            emp1.showemployeesalary();
        }


    }

}
