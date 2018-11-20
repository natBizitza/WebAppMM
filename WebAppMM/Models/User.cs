using System.Dynamic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace WebAppMM.Models
{
    public class User
    {
        [Key]
        public int IDUser { get; set; }
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
        public List<Place> Places { get; set; }
    }
}
