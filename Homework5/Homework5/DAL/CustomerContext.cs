using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Homework5.DAL
{
    /// <summary>
    /// Customer Context for DMV
    /// </summary>
    public class CustomerContext : DbContext
    {
<<<<<<< HEAD
        /// <summary>
        /// Superclass Constructor
        /// </summary>
=======
>>>>>>> HW5_Form
        public CustomerContext() : base("name=OurDBContext")
        { }

        /// <summary>
        /// This is the getter and setter method for each Customer in Customers
        /// </summary>
        public virtual DbSet<Customer> Customers { get; set; }
    }
}