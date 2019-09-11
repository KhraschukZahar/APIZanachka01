using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class DBRole : IdentityRole<int>
    {
        public ICollection<DBUserRole> UserRoles { get; set; }
    }
}
