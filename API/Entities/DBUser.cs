using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class DBUser : IdentityUser<int>
    {
    
        public ICollection<DBUserRole> UserRoles { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
    }
}
