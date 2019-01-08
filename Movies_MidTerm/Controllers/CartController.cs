using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies_MidTerm.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Movies_MidTerm.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cart/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cart/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Create(int Index)
        {
            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
            //TextWriter writer;
            //using (writer = new StreamWriter(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\cartItems.json", append: true))
            //{
            //    writer.WriteLine(movie);
            //}
            return "";

        }
        public ActionResult AddToCart(Movie movie)
        {
            TextWriter writer;
            List<Movie> movies = new List<Movie>();
            //get current objects from cart
            using (StreamReader r = new StreamReader(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\cartItems.json"))
            {
                if (r.BaseStream.Length > 0)
                {
                    JObject o = JObject.Parse(r.ReadToEnd());
                    movies = o.SelectToken("cartItem").Select(jt => jt.ToObject<Movie>()).ToList();
                }
            }
            if (movie.description != null){
                movies.Add(movie);
            }
            var cartItems = new { cartItem = movies };
            JObject ja = (JObject)JToken.FromObject(cartItems);
            //add more items to existing items in cart
            using (writer = new StreamWriter(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\cartItems.json", append: false))
            {
                writer.WriteLine(ja);
            }
            ViewBag.Movies = movies;
            using (StreamReader r = new StreamReader(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\cartItems.json"))
            {
                JObject o = JObject.Parse(r.ReadToEnd());
                var listOfCartItems = o.SelectToken("cartItem").Select(jt => jt.ToObject<Movie>()).ToList();
                ViewBag.cartItems = listOfCartItems;
            }
            return View();
        }

        public ActionResult DeleteFromCart(int index)
        {
            TextWriter writer;
            List<Movie> movies = new List<Movie>();
            //get current objects from cart
            using (StreamReader r = new StreamReader(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\cartItems.json"))
            {
                if (r.BaseStream.Length > 0)
                {
                    JObject o = JObject.Parse(r.ReadToEnd());
                    movies = o.SelectToken("cartItem").Select(jt => jt.ToObject<Movie>()).ToList();
                }
            }
            movies.RemoveAt(index);
            var cartItems = new { cartItem = movies };
            JObject ja = (JObject)JToken.FromObject(cartItems);
            //add more items to existing items in cart
            using (writer = new StreamWriter(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\cartItems.json", append: false))
            {
                writer.WriteLine(ja);
            }
            ViewBag.Movies = movies;
            using (StreamReader r = new StreamReader(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\cartItems.json"))
            {
                JObject o = JObject.Parse(r.ReadToEnd());
                var listOfCartItems = o.SelectToken("cartItem").Select(jt => jt.ToObject<Movie>()).ToList();
                ViewBag.cartItems = listOfCartItems;
            }
            return View();
        }
        // GET: Cart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cart/Edit/5
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

        // GET: Cart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cart/Delete/5
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