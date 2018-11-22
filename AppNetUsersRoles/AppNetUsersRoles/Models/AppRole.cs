using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppNetUsersRoles.Models
{
    public class AppRole : IdentityRole
    {

        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        //constructors
        public AppRole() : base()
        {

        }

        public AppRole(string roleName) : base (roleName)
        {

        }

        public AppRole(string roleName, string description, DateTime creationDate) : base(roleName)
        {
            this.Description = description;
            this.CreationDate = creationDate;

        }
    }
}
