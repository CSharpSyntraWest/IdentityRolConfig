using IdentityRolConfig.Models.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityRolConfig.Models
{
    public class ApplicationContext : IdentityDbContext<IdentityUser> // DbContext
    {
        public ApplicationContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
