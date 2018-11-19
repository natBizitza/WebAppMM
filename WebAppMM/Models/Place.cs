using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMM.Models
{
    public class Place
    {
        [Key]
        public int IDPlace { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        //public List<Place> Places { get; set; }
    }
}
