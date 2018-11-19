using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMM.Models
{
    public class ViewModel
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int IDUser;
        [ForeignKey("Place")]
        public int IDPlace;
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Place> Places { get; set; }
    }
}
