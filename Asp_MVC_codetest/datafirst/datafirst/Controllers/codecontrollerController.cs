using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using datafirst.Models;
namespace datafirst.Controllers
{
    public class codecontrollerController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        private NorthwindEntities db =new NorthwindEntities();
        public ActionResult GermanCustomers()
        {
            var germanCustomers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germanCustomers);
        }
        public ActionResult CustomerDetailsWithOrderId()
        {
            var customerDetails = (from c in db.Customers
                                   join o in db.Orders on c.CustomerID equals o.CustomerID
                                   where o.OrderID == 10248
                                   select new details 
                                   {
                                       customer = c,
                                       order = o
                                   }).FirstOrDefault();

            return View(customerDetails);
        }

    }

    
}