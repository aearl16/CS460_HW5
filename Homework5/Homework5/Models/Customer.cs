using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework5.Models
{
    public class Customer
    {
        public DateTime DOB { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { set; get; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
    }
}