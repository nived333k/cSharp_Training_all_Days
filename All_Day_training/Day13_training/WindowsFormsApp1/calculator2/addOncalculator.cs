using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculatorDLL;
namespace calculator2
{
    public static class addOncalculator
    {
        public static int substract2Nos(this calculatorclass cobj ,int x , int y)
        {
            return x - y;
        }
        public static int mult2nos(this calculatorclass cobj , int x ,int y)
        {
            return x * y;
        }
    }
}
