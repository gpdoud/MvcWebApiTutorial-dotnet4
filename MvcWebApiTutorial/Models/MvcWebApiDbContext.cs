using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcWebApiTutorial.Models {

	public class MvcWebApiDbContext : DbContext {

		public MvcWebApiDbContext() : base() { }

		public DbSet<Customer> Customers { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}