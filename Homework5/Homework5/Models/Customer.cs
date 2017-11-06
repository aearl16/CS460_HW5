using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework5.Models
{
    /// <summary>
    /// DMV Customer Model
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Customer ID, used as PK
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Date of Birth
        /// </summary>
        [Required]
        public DateTime DOB { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        [Required, StringLength(64)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [Required, StringLength(64)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Middle Name
        /// </summary>
        [Required, StringLength(64)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Address, this one is Required, Mailing is not
        /// </summary>
        [Required, StringLength(256)]
        [Display(Name = "Address")]
        public string CAddress { set; get; }

        /// <summary>
        /// Mailing, not required
        /// </summary>
        [Required, StringLength(256)]
        [Display(Name = "Mailing Address")]
        public string MailingAddress { get; set; }

        /// <summary>
        /// Mailing City, Not required
        /// </summary>
        [Display(Name = "Mailing City")]
        public string MailingCity { get; set; }

        [Display(Name = "Mailing Zipcode")]
        public int MailingZip { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [Required, StringLength(64)]
        [Display(Name = "City")]
        public string City { get; set; }

        /// <summary>
        /// State, note: named CState because state is a keyword in C#
        /// </summary>
        [Required, StringLength(64)]
        [Display(Name = "State")]
        public string CState { get; set; }

        /// <summary>
        /// Zipcode
        /// </summary>
        [Required]
        [Display(Name = "Zipcode")]
        public int Zipcode { get; set; }

        /// <summary>
        /// Mailing State, not required
        /// </summary>
        [Display(Name = "Mailing State")]
        public string MailingState { get; set; }
    }
}