using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This is a Dynamic Link library . 
//exe works on its own memory address
//Dll can not invoke by it self 
namespace MyDll
{
    public class Class1
    {
        public string Method()
        {
            return "this is from dll";
        }
    }
}
