using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency_injection
{
    public interface Iaccount
    {
        void printdetails();

    }
    class current__account : Iaccount
    {
        public void printdetails()
        {
            Console.WriteLine("Details of current account");
        }
    }
    class saving__account : Iaccount
    {
        public void printdetails()
        {
            Console.WriteLine("Details of savings account");
        }
    }

    class account2
    {
        public Iaccount account { get; set; }

        public void printaccount()
        {
            account.printdetails();
        }
    }

    class diprop
    {
        static void Main()
        {
            account2 sa = new account2();
            sa.account = new saving__account();
            sa.printaccount();
           

            account2 ca = new account2();
            ca.account = new current__account();
            ca.printaccount();
            Console.ReadLine();
        }
    }
}
