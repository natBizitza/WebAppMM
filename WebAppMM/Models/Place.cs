using System.Dynamic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppMM.Models
{
    public class Place
    {
        //[Key]
        public int ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}
