using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//DI using constructor Injection in C#
namespace dependency_injection
{

    public interface IInterface
    {
        void printdetails();
    }

    class currentaccount : IInterface
    {
        public void printdetails()
        {
            Console.WriteLine("Details of Current Account");
        }
    }

    class savingaccount : IInterface
    {
        public void printdetails()
        {
            Console.WriteLine("Details of saving account");
        }
    }

    class account1
    {
        private IInterface Account1;
        public account1(IInterface Account1) //parameterized constructor
        {
            this.Account1 = Account1;
        }
        public void printaccount()
        {
            Account1.printdetails();
        }
    }
    class program1
    {
        static void Main()
        {
            IInterface ca = new currentaccount();
            account1 c = new account1(ca);
            c.printaccount();
            //here interface is doing de-coupling 
            IInterface sa = new savingaccount();
            account1 s = new account1(sa);
            s.printaccount();
            Console.ReadLine();

        }
    }
}
