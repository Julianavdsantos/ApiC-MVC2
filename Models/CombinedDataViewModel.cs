using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CombinedDataViewModel
    {

        public List<Peoples> Peoples { get; set; }
        public List<Films> Films { get; set; }
          public List<Starships> Starships { get; set; }
        
        public List<Planets> Planets { get; set; }
        public List<Peoples> People { get; internal set; }

        public CombinedDataViewModel()
        {
            Films = new List<Films>();
            Peoples = new List<Peoples>();
            Planets = new List<Planets>();
        }
    }



}
