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

        public ActionResult CustomerDelete()
        {
            return View();
        }

        public ActionResult CustomerEdit()
        {
            return View();
        }

        public ActionResult CustomerCreate()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}