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
    public class HomeController : Controller
    {
        private CustomerContext cc = new CustomerContext();

        public ActionResult Index()
        {
            return View();
        }

        //Customer GET
        public ActionResult CustomerView()
        {
            return View(cc.Customers.ToList());
        }

        // GET: Home/CustomerDetails/2
        public ActionResult CustomerDetails(int? id)
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

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CustomerList()
        {
            return View(cc.Customers.ToList());
        }
    }
}