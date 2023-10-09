using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Films
    {
        [JsonProperty("episode_id")]
       

        public int EpisodeId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("director")]
        public string Director { get; set; }
        [JsonProperty("producer")]
        public string Producer { get; set; }
        [JsonProperty("opening_crawl")]
        public string OpeningCrawl { get; set; }
        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

        
    }
   
}
