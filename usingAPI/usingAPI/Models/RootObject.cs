using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace usingAPI.Models
{
    public class RootObject
    {

        public int Count { get; set; }
        public string Next { get; set; }
        public object Previous { get; set; }

        //to change the name from results to Characters
        [JsonProperty(PropertyName = "results")]

        public List<Character> Characters { get; set; }
    }
}
