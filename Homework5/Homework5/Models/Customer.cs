using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework5.Models
{
    public class Customer
    {
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
        public string Address { set; get; }

        [Required, StringLength(256)]
        [Display(Name = "Mailing Address")]
        public string MailingAddress { get; set; }

        [Display(Name = "Mailing Address")]
        public string MailingCity { get; set; }

        [Display(Name = "Mailing Zip")]
        public int MailingZip { get; set; }

        [Required, StringLength(64)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required, StringLength(256)]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Mailing Address")]
        public int Zipcode { get; set; }
    }
}