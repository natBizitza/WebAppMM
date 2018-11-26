using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMM.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base()
        {

        }

        public ApplicationRole(string roleName) : base(roleName)
        {

        }

        public ApplicationRole(string roleName, string description, DateTime creationDate) : base(roleName)
        {
            this.Description = Description;
            this.CreationDate = CreationDate;


        }

        public string Description { get; set; }
        public DateTime CreationDate { get; private set; }
    }
}
