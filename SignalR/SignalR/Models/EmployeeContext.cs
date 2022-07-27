using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("dbConnectionString")
        {
            Database.SetInitializer<EmployeeContext>(new CreateDatabaseIfNotExists<EmployeeContext>());
        }
        public DbSet<Employee> Employees { get; set; }
    }
}