using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using codefirstQuestion2.Models;
using System.Data.Entity;

namespace codefirstQuestion2.Controllers
{
    public class HomeController : Controller
    {
        MovieContext db = new MovieContext();

        // GET: Home
        public ActionResult Index()
        {
            var data = db.movies.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MovieDB m)
        {
            if (ModelState.IsValid == true)
            {
                db.movies.Add(m);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["insertmessage"] = "data inserted";
                    //ModelState.Clear();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["insertmessage"] = "data not inserted";
                }

            }
            return View();

        }
        public ActionResult Edit(int id)
        {
            var movierow = db.movies.Where(model => model.Mid == id).FirstOrDefault();
            return View(movierow);

        }
        [HttpPost]
        public ActionResult Edit(MovieDB m)
        {
            db.Entry(m).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                //ViewBag.updatemessage = "the data is edited succesfully";
                //ModelState.Clear();

                TempData["updatemessage"] = "the data is edited succesfully";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.updatemessage = "the data is edited unsuccesfully";
            }
            return View();

        }
        public ActionResult Delete(int id)
        {
            var movieIDRow = db.movies.Where(model => model.Mid == id).FirstOrDefault();
            return View(movieIDRow);
        }
        [HttpPost]
        public ActionResult Delete(MovieDB m)
        {
            db.Entry(m).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                TempData["deletedmessage"] = "data deleted";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.deletedmessage = "data not deleted";
            }

            return View();
        }


        public ActionResult Details(string year)
        {
            var movies = db.movies.Where(model=> model.MovieDate == year).ToList();
            ViewBag.Year = year;
            return View("Index", movies);
        }

    }

}