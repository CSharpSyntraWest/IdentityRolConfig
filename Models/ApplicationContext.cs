using IdentityRolConfig.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace IdentityRolConfig.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
