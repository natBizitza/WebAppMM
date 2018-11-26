using System.Dynamic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Identity;

namespace WebAppMM.Models
{
    public class User : IdentityUser
    {
        public User() : base()
        {

        }
        //[Key]
        public int ID { get; set; }
        public string  FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LanguagePreferred { get; set; }
        public string Currency { get; set; }
        public string AboutMe { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfRegistration { get; set; }
        //public Place Place { get; set; }
    }
}
