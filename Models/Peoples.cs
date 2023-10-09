using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Peoples
    {

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("height")]
        public string Height { get; set; }
        [JsonProperty("mass")]
        public string Mass { get; set; }
        [JsonProperty("hair_color")]
        public string HairColor { get; set; }
        public List<string> Residents { get; set; }
        [JsonProperty("id")] // Adicione essa anotação se a API retornar um campo "id"
        public int Id { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("birth_year")]

        public string BirthYear { get; set; }

    }
}
