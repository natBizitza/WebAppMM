using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppNetUsersRoles.Models
{
    public class AppUser : IdentityUser
    {
        //to pick up all the attrs of  Identity User
        public AppUser() : base()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
