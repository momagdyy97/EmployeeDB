using Microsoft.EntityFrameworkCore;
using EmployeesApp.Models;
namespace EmployeesApp.Models 
{
    public class HRDatabaseContext : DbContext
    {
        public HRDatabaseContext(DbContextOptions<HRDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }

}
