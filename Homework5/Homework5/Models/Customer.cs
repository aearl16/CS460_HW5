using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework5.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required, StringLength(64)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, StringLength(64)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, StringLength(64)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required, StringLength(256)]
        [Display(Name = "Address")]
        public string CAddress { set; get; }

        [Required, StringLength(256)]
        [Display(Name = "Mailing Address")]
        public string MailingAddress { get; set; }

        [Display(Name = "Mailing City")]
        public string MailingCity { get; set; }

        [Display(Name = "Mailing Zipcode")]
        public int MailingZip { get; set; }

        [Required, StringLength(64)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required, StringLength(64)]
        [Display(Name = "State")]
        public string CState { get; set; }

        [Required]
        [Display(Name = "Zipcode")]
        public int Zipcode { get; set; }

        [Display(Name = "Mailing State")]
        public string MailingState { get; set; }
    }
}