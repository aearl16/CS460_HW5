using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Homework5.DAL
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("name=OurDBContext")
        { }

        public virtual DbSet<Customer> Customers { get; set; }
    }
}