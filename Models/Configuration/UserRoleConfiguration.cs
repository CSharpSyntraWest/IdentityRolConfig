using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityRolConfig.Models.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {

            IdentityUserRole<string> iur = new IdentityUserRole<string>
            {
                RoleId = Constants.AdminRoleId,
                UserId = Constants.AdminUserId
            };

            IdentityUserRole<string> vur = new IdentityUserRole<string>
            { 
                RoleId = Constants.VisitorRoleId,
                UserId = Constants.VisitorUserId
            };

            builder.HasData(iur,vur);
        }
 }

}
