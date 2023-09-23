using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class conscession
    {
        public  int TicketPrice = 500;
        public string name;
        public int age;

        public void calculateConsession()
        {
            if (age <= 5)
            {
                Console.WriteLine("your name is {0} and your age is {1} Little champ you have won a free ticket ",name,age);
            }
            else if (age > 60)
            {
                double TicketFair = TicketPrice * 0.30;
                double discountprice = TicketPrice - TicketFair;
                Console.WriteLine("senior citizen ticket price {0} \n your name is {1} your age is {2}",discountprice,name,age);
            }

            else
            {
                Console.WriteLine("your tickets are booked {0} and your name is {1} and your age is {2}",TicketPrice,name,age);
            }

        }
        
    }

}
