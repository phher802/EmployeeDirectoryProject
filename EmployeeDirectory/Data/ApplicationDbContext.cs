 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDirectory.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectory
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

    }
}
