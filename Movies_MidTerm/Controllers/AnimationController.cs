using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies_MidTerm.Models;
using Newtonsoft.Json.Linq;

namespace Movies_MidTerm.Controllers
{
    public class AnimationController : Controller
    {
        // GET: Animation
        public ActionResult Index()
        {
            using (StreamReader r = new StreamReader(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\AnimationMovies.json"))
            {
                JObject o = JObject.Parse(r.ReadToEnd());
                var movies = o.SelectToken("AnimationMovies").Select(jt => jt.ToObject<Movie>()).ToList();
                ViewBag.Movies = movies;
            }
            return View();
        }

        // GET: Animation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Animation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Animation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Animation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Animation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Animation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Animation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}