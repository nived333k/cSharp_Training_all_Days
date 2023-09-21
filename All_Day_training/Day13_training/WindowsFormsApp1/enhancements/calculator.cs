using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculatorDLL;
using calculator2;

namespace enhancements
{
    class calculator
    {
        static void Main()
        {
            calculatorclass cc = new calculatorclass();
            Console.WriteLine(cc.addtwoNumbers(2, 4));
            Console.WriteLine(cc.welcomefunction("nived"));
            Console.WriteLine(cc.mult2nos(2, 3));
            Console.WriteLine(cc.substract2Nos(3,4));
            
            Console.ReadLine();
        }
    }
}
