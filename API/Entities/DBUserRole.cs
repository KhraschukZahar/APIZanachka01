using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class DBUserRole : IdentityUserRole<int>
    {     
            public virtual DBUser User { get; set; }
            public virtual DBRole Role { get; set; }
    }
}
