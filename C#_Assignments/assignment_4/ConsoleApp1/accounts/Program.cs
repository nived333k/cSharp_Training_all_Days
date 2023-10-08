using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accounts
{
    
     internal class accounts
    {

        public int accountNo;
        public string customerName;
        public string accountType;
        public string transactionType;
        public double amount;
        public double balance = 15000;

        public void userScreen()
        {
            Console.WriteLine("enter account number  ");
            this.accountNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the customer name  ");
            this.customerName = Console.ReadLine();

            Console.WriteLine("enter the account type");
            this.accountType = Console.ReadLine();

            Console.WriteLine("enter your transaction type. you can type d or w which is deposit or withdrawal");
            this.transactionType = Console.ReadLine();

            Console.WriteLine("enter the amount you want to withdraw or deposit ");
            this.amount = Convert.ToDouble(Console.ReadLine());


            // now we will run a if else loop accordingly what user enter if its deposit or withdraw .
            // but the withdraw amount should be less than the balance which is 15k.

            if (transactionType == "d")
            {

                balance = balance + amount;

            }
            else if (transactionType == "w" && amount < balance)
            {
                balance = balance - amount;
            }
            else if (transactionType == "w" && amount > balance)
            {
                Console.WriteLine("Balance is low please check ");
            }

            Console.WriteLine($" 1.account number = {accountNo} \n 2.customer name = {customerName} \n 3.account type = {accountType} \n 4.transaction type = {transactionType} \n 5. amount = {amount} \n 6.balance ={balance}");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            accounts user = new accounts();
            user.userScreen();

        }

    }
}
