using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Identity
{
    public class ApplicationUser: IdentityUser
    {
        public DateTime Created { get; set; }
        public DateTime? LastPasswordChangeDate { get; set; }
        public bool NeedChangePassword { get; set; }
    }
}
