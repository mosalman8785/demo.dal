using demo.dal.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.dal.Context
{
	public class appDbContext : IdentityDbContext<ApplicationUser>
	{
		public appDbContext(DbContextOptions<appDbContext> options) : base(options)
		{
		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Department { get; set; }
	}
}
