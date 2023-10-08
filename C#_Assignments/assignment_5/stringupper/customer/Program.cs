using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer
{


    class customer
    {
        public int cust_id { get; set; }
        public string cust_name { get; set; }
        public int cust_age { get; set; }
        public string cust_phone { get; set; }
        public string cust_city { get; set; }

        //constructor with no arguments
        public customer()
        {

        }

        public customer(int cust_id , string cust_name , int cust_age , string cust_phone , string cust_city)
        {
            this.cust_id = cust_id;
            this.cust_name = cust_name;
            this.cust_age = cust_age;
            this.cust_phone = cust_phone;
            this.cust_city = cust_city;
        }
        public void displaycustomer()
        {
            Console.WriteLine($"1.customer id: {cust_id} \n 2.customer name: {cust_name} \n 3.customer age:{cust_age} \n 4.customer phone: {cust_phone} \n 5.customer city:{cust_city}");
            Console.ReadLine();
        }

        //distructor
        ~customer()
        {

        }
    }

    



    class Program
    {
        static void Main(string[] args)
        {
            customer user1 = new customer(1, "nived", 21, "2322898392", "Bangalore");
            user1.displaycustomer();
        }
    }
}
