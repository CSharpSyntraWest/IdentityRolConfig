using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityRolConfig.Models.Configuration
{
    public static class Constants
    {
        //Guid guid = Guid.NewGuid();
        public static string AdminUserId = Guid.NewGuid().ToString();
        public static string VisitorUserId = Guid.NewGuid().ToString();
        public static string AdminRoleId = Guid.NewGuid().ToString();
        public static string VisitorRoleId = Guid.NewGuid().ToString();
    }
}
