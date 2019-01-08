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
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult Index()
        {
            return View();
        }

        // GET: Address/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Address/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Address/Create
        [HttpPost]
        public ActionResult Index(Address ad)
        {
            Address newAddress = new Address();
            newAddress.FullName = ad.FullName == null ? "":ad.FullName;
            newAddress.AddressLine1 = ad.AddressLine1 == null ? "" : ad.AddressLine1;
            newAddress.AddressLine2 = ad.AddressLine2 == null ? "" : ad.AddressLine2;
            newAddress.City = ad.FullName == null ? "" : ad.City;
            newAddress.ZipCode = ad.ZipCode == null ? "" : ad.ZipCode;
            newAddress.PhoneNumber = ad.PhoneNumber == null ? "" : ad.PhoneNumber;
            newAddress.State = ad.State == null ? "" : ad.State;

            List<Address> addresses = new List<Address>();
                addresses.Add(newAddress);
            TextWriter writer;
            // TODO: Add insert logic here
            var address = new { address = addresses };

            JObject ja = (JObject)JToken.FromObject(address);
                //add more items to existing items in cart
                using (writer = new StreamWriter(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\Address.json", append: false))
                {
                    writer.WriteLine(ja);
                }

                return RedirectToAction(nameof(Payment));
           
        }
        public ActionResult Payment()
        {
            return View();
        }


        // POST: Address/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Address collection)
        {
            try
            {
                // TODO: Add insert logic here
                //var cartItems = new { cartItem = movies };
                //JObject ja = (JObject)JToken.FromObject(cartItems);
                ////add more items to existing items in cart
                //using (writer = new StreamWriter(@"C:\\Users\anush\\source\repos\\Movies_MidTerm\\Movies_MidTerm\\MovieDB\\cartItems.json", append: false))
                //{
                //    writer.WriteLine(ja);
                //}

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: Address/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Address/Edit/5
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

        // GET: Address/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Address/Delete/5
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