using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TP1_.NET.Models;
using TP1_.NET.Models.DAL;

namespace TP1_.NET.Controllers
{
    public class MoviesMController : Controller
    {
        MovieDbContext db = new MovieDbContext();
        // GET: MoviesM
        public ActionResult Index()
        {
            // Movie m = new Movie() {Title= "The100",Genre ="Aventure",ReleaseDate= new DateTime(2013,10,10),ID=12,Price=22};
            // db.Movies.Add(m);
            // db.SaveChanges();
            return View(db.Movies.ToList());
        }
        public ActionResult Ajouter()
        {
            return View();
        }        
        
        public ActionResult AjouterBase(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("~/Views/MoviesM/Ajouter.cshtml", movie);
            }
        }
        public ActionResult Modifier(int? id)
        {
            if(id ==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if(movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);

        }



        [HttpPost]
        public ActionResult Modifier(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("~/Views/MoviesM/Modifier.cshtml", movie);
            }
        }

        public ActionResult Supprimer(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [HttpPost, ActionName("Supprimer")]
        [ValidateAntiForgeryToken]
        public ActionResult SuppConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}