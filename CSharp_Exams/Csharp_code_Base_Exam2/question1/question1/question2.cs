using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{

    class product
    {
        //we are creating properties
        public int product_id { get; set; }
        public string product_name { get; set; }
        public double product_price { get; set; }

        //create a constructor for the properties
        public product(int pid, string pname, double pprice)
        {
            product_id = pid;
            product_name = pname;
            product_price = pprice;

        }

    }

    class question2
    {
        static void Main()
        {
            List<product> products_list = new List<product>();

            //to accept 10 product
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("enter products id");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the name of products");
                string product_name = Console.ReadLine();
                Console.WriteLine("enter the price of items");
                double product_price = Convert.ToDouble(Console.ReadLine());
                products_list.Add(new product(i, product_name, product_price));
            }
            // to sort product by price
            products_list = products_list.OrderBy(p => p.product_price).ToList();

            //sort products
            Console.WriteLine("sorted by price");
            foreach (var prod in products_list)
            {
                Console.WriteLine($"1.productid {prod.product_id} \n 2.productname  {prod.product_name} \n 3.productprice{prod.product_price}");
            }
            Console.ReadLine();
        }

    }
}
