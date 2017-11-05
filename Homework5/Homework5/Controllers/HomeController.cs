using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework5.Models;
using Homework5.DAL;
using System.Net;

namespace Homework5.Controllers
{
    /// <summary>
    /// Main controller for DMV forms
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// The context for my Customer Model
        /// </summary>
        private CustomerContext cc = new CustomerContext();

        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/CustomerDetails/2
        /// <summary>
        /// Details for a specific customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer cust = cc.Customers.Find(id);
            if (cust == null)
            {
                return HttpNotFound();
            }
            return View(cust);
        }

        //Get
        /// <summary>
        /// Delete method for Customers
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer cust = cc.Customers.Find(id);
            if (cust == null)
            {
                return HttpNotFound();
            }
            return View(cust);
        }

        //Post
        /// <summary>
        /// Confirmation method for Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer cust = cc.Customers.Find(id);
            cc.Customers.Remove(cust);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Edit Method for Customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer cust = cc.Customers.Find(id);
            if (cust == null)
            {
                return HttpNotFound();
            }
            return View(cust);
        }

        /// <summary>
        /// Create method. Displays the creation view
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        //Post
        /// <summary>
        /// Create Post Method
        /// </summary>
        /// <param name="cust"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,DOB,Address,City, CState, Zipcode")] Customer cust)
        {
            if (ModelState.IsValid)
            {
                cc.Customers.Add(cust);
                cc.SaveChanges();
                return RedirectToAction("CustomerList");
            }

            return View(cust);
        }

        /// <summary>
        /// Lists the customers in the SQL DB and displays them as a list
        /// </summary>
        /// <returns></returns>
        public ActionResult CustomerList()
        {
            return View(cc.Customers.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                cc.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}