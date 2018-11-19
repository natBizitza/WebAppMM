using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMM.Models
{
    public class UsersPlaces
    {
        public int PlaceId { get; set; }
        public int UserId { get; set; }
        public List<Place> Places { get; set; }
        public List<User> Users { get; set; }
    }
}
