using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMM.Models
{
    public class ASPUser : IdentityUser
    {
        public ASPUser() : base ()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
