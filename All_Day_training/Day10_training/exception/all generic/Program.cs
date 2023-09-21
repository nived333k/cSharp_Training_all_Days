using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_generic
{
    class all_generic<T>
    {

        private T genericfield;
        //generic constructor
        public all_generic (T val)
        {
            genericfield = val;
        }

        //generic method();
        public T genericMethod(T genricparameter)
        {
            Console.WriteLine("Parameter Type  is {0} , value{1}",typeof(T).ToString(),genricparameter);
            Console.WriteLine("return type is :{0}, value is{0}",typeof(T).ToString(),genricparameter);
            return genericfield;
        }
        static void Main(string[] args)
        {
            
        }
    }


    class Testallgenerics
    {
        static void Main()
        {
            all_generic<int> intgeneric = new all_generic<int>(10);
            Console.WriteLine(intgeneric.genericMethod(100));
            Console.WriteLine("-----------");

        }
    }
}
