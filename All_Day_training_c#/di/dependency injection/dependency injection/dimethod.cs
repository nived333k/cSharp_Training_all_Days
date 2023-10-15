using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency_injection
{

    public interface Imethod
    {
        void printdetails();
    }
    class current___account : Imethod
    {
        public void printdetails()
        {
            Console.WriteLine("Details of current account");
        }
    }
    class savings___account : Imethod
    {
        public void printdetails()
        {
            Console.WriteLine("Details of saving account");
        }
    }

    class account3
    {
        public void printaccount(Imethod account)
        {
            account.printdetails();
        }
      
    }
    class dimethod
    {
        static void Main()
        {
            account3 sa = new account3();
            sa.printaccount(new savings___account());
            account3 ca = new account3();
            ca.printaccount(new current___account());

            Console.ReadLine();


        }
    }
}
