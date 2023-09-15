using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sale
{

    internal class saledetails
    {
        public int salesno;
        public int productno;
        public double price;
        public DateTime dateofsale;
        public int qty;
        public double totalamt;


        public saledetails(int salesno , int productno , double price , DateTime dateofsales , int qty )
        {
            this.salesno = salesno;
            this.productno = productno;
            this.price = price;
            this.dateofsale = dateofsale;
            this.qty = qty;
            
        }

        public void sales()
        {
            totalamt = qty * price;
        }
        public void showdata()
        {
            Console.WriteLine($" 1.salesno: {salesno} \n 2.productNo: {productno} \n 3.price: {price} \n 5.qty: {qty} \n 6.total amount: {totalamt}");
            Console.WriteLine("date of sales: "+dateofsale.ToString("yyyy-MM-dd"));
            Console.ReadLine();
        }
    
    
    
    }


    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse("2023-09-15");
            saledetails info = new saledetails(001 ,23003,230000,date,2);
            info.sales();
            info.showdata();
        }
    }
}
