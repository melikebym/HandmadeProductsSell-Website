using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_CommerceAppMVC.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace E_CommerceAppMVC.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection")
        {
        }
    }
}