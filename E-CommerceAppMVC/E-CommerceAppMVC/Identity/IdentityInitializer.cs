using E_CommerceAppMVC.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_CommerceAppMVC.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
                if (!context.Roles.Any(i => i.Name == "admin"))
                {
                    var store = new RoleStore<ApplicationRole>(context);
                    var manager = new RoleManager<ApplicationRole>(store);
                    var role = new ApplicationRole() { Name = "admin", Description = "admin rolü"};

                    manager.Create(role);
                }

                if (!context.Roles.Any(i => i.Name == "user"))
                {
                    var store = new RoleStore<ApplicationRole>(context);
                    var manager = new RoleManager<ApplicationRole>(store);
                    var role = new ApplicationRole() { Name ="user", Description = "user rolü"};

                    manager.Create(role);
                }

                if (!context.Roles.Any(i => i.Name == "Admin"))
                {
                    var store = new UserStore<ApplicationUser>(context);
                    var manager = new UserManager<ApplicationUser>(store);
                    var user = new ApplicationUser() { Name = "Admin", Surname = "Admin", UserName = "Admin", Email = "admin@gmail.com"};

                    manager.Create(user, "123456");
                    manager.AddToRole(user.Id, "admin");
                    manager.AddToRole(user.Id, "user");
                }



            base.Seed(context);
        }
    }
}