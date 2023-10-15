using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency_injection
{
    // The below program is a examole of tight coupling 
    class current_account
    {
        public void printdetails()
        {
            Console.WriteLine("Details of current account");
        }
    }
    class saving_account
    {
        public void printdetails()
        {
            Console.WriteLine("Details of savings account");
        }
    }
    class account
    {
        current_account ca = new current_account();
        saving_account sa = new saving_account();

        public void printaccount()
        {
            ca.printdetails();
            ca.printdetails();
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            account a = new account();
            a.printaccount();
            Console.ReadLine();
        }
    }
}
