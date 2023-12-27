using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Planets
    {

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("rotation_period")]
        public string RotationPeriod { get; set; }
        [JsonProperty("orbital_period")]
        public string OrbitalPeriod { get; set; }
        [JsonProperty("diameter")]
        public string Diameter { get; set; }
        public List<string> Residents { get; set; }
     
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }


    }
}
