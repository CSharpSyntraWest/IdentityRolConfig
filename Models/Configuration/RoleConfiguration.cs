using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityRolConfig.Models.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = Constants.AdminRoleId,
                Name = "Visitor",
                NormalizedName = "VISITOR"
            },
            new IdentityRole
            {
                Id = Constants.VisitorRoleId,
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            }); ;
        }
    }
}
