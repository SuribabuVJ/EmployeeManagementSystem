using Employee.Business.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace Employee.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee.Business.EntityModels.Employee> Employees { get; set; }
    }
}