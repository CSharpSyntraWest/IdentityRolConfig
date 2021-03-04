using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityRolConfig.Models.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(
             new IdentityUser
             {
                  Id = Constants.AdminUserId,
                  UserName = "Jos",
                  NormalizedUserName="JOS",
                  Email = "jos@gmail.com",
                  NormalizedEmail = "JOS@GMAIL.COM"
             },
             new IdentityUser
             {
                 Id = Constants.VisitorUserId,
                 UserName = "Joke",
                 NormalizedUserName = "JOKE",
                 Email = "joke@hotmail.com",
                 NormalizedEmail = "JOKE@HOTMAIL.COM"
             });
        }
    }
}
