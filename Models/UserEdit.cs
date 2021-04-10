using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex_Remix.Models
{
    public class UserEdit
    {
        public IdentityUser Role { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
        public IEnumerable<IdentityRole> NonRoles { get; set; }
    }
}
