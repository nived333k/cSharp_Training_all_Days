using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using codefirst.Models;

namespace codefirst.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDbContext _dbContext = new MoviesDbContext();

        public ActionResult Index()
        {
            var movies = _dbContext.Movie.ToList();
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(movies movie)
        {
            _dbContext.Movie.Add(movie);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var movie = _dbContext.Movie.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(movies movie)
        {
            _dbContext.Entry(movie).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var movie = _dbContext.Movie.Find(id);
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var movie = _dbContext.Movie.Find(id);
            _dbContext.Movie.Remove(movie);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}