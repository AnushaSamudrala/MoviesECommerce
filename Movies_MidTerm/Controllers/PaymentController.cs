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
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Index()
        {
            return View();
        }

        // GET: Payment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Payment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Payment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Payment p)
        {
            TextWriter writer;
            List<Payment> payments = new List<Payment>();
            payments.Add(p);
            // TODO: Add insert logic here
            var payment = new { payment = payments };

            JObject ja = (JObject)JToken.FromObject(payment);
            //add more items to existing items in cart
            using (writer = new StreamWriter(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\Payment.json", append: false))
            {
                writer.WriteLine(ja);
            }
            return RedirectToAction(nameof(Summary));

        }
        public ActionResult Summary()
        {
            using (StreamReader r = new StreamReader(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\cartItems.json"))
            {
                JObject o = JObject.Parse(r.ReadToEnd());
                var moviesCount = o.SelectToken("cartItem").Select(jt => jt.ToObject<Movie>()).ToList().Count();
                //JsonSerializer serializer = new JsonSerializer();
                //Address address=(Address)serializer.Deserialize(r, typeof(Address));
                ViewBag.moviesCount = moviesCount;
                ViewBag.totalPrice = 20 * moviesCount;
                ViewBag.totalTax = (20 * moviesCount)*10/100;
                ViewBag.total = (20 * moviesCount)+((20 * moviesCount)*10 / 100);


            }
            using (StreamReader r = new StreamReader(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\Address.json"))
            {
                JObject o = JObject.Parse(r.ReadToEnd());
                var address = o.SelectToken("address").Select(jt => jt.ToObject<Address>()).ToList()[0];
                //JsonSerializer serializer = new JsonSerializer();
                //Address address=(Address)serializer.Deserialize(r, typeof(Address));
                ViewBag.address = address;
            }
            using (StreamReader r = new StreamReader(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\Payment.json"))
            {
                JObject o = JObject.Parse(r.ReadToEnd());
                var payment = o.SelectToken("payment").Select(jt => jt.ToObject<Payment>()).ToList()[0];
                ViewBag.payment = payment;
            }
            return View();
        }
        // GET: Payment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Payment/Edit/5
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

        // GET: Payment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Payment/Delete/5
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