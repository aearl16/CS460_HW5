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
<<<<<<< HEAD
        /// <summary>
        /// The context for my Customer Model
        /// </summary>
=======
>>>>>>> HW5_Form
        private CustomerContext cc = new CustomerContext();

        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/CustomerDetails/2
<<<<<<< HEAD
        /// <summary>
        /// Details for a specific customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
=======
>>>>>>> HW5_Form
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
<<<<<<< HEAD
        /// <summary>
        /// Delete method for Customers
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
=======
>>>>>>> HW5_Form
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
<<<<<<< HEAD
        /// <summary>
        /// Confirmation method for Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
=======
>>>>>>> HW5_Form
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer cust = cc.Customers.Find(id);
            cc.Customers.Remove(cust);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }

<<<<<<< HEAD
        /// <summary>
        /// Edit Method for Customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
=======
>>>>>>> HW5_Form
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

<<<<<<< HEAD
        /// <summary>
        /// Create method. Displays the creation view
        /// </summary>
        /// <returns></returns>
=======
>>>>>>> HW5_Form
        public ActionResult Create()
        {
            return View();
        }

        //Post
<<<<<<< HEAD
        /// <summary>
        /// Create Post Method
        /// </summary>
        /// <param name="cust"></param>
        /// <returns></returns>
=======
>>>>>>> HW5_Form
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

<<<<<<< HEAD
        /// <summary>
        /// Lists the customers in the SQL DB and displays them as a list
        /// </summary>
        /// <returns></returns>
=======
>>>>>>> HW5_Form
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