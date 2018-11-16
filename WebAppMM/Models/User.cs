using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMM.Models
{
    public class User
    {
        public int ID { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LanguagePreferred { get; set; }
        public string Currency { get; set; }
        public string AboutMe { get; set; }
        public DateTime DateOfRegistration { get; set; }
    }
}
