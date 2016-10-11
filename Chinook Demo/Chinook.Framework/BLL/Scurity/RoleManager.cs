﻿using Chinook.Framework.DAL.Security;
using Chinook.Framework.Entities.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq; // Bring in the .Any() extension method

namespace Chinook.Framework.BLL.Scurity
{
    public class RoleManager : RoleManager<IdentityRole>
    {
        public RoleManager()
            : base(new RoleStore<IdentityRole>(new ApplicationDbContext()))
        {
        }

        public void AddDefaultRoles()
        {
            foreach (string roleName in SecurityRoles.DefaultSecurityRoles)
            {
                // check if it exists
                if (!Roles.Any(r => r.Name == roleName))
                    this.Create(new IdentityRole(roleName));
            }
        }
    }
}
