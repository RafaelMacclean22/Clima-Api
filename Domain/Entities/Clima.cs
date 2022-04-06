using OpenWeatherAPI.Domain.Entities.Climate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
  public  class Clima
    {
        public Coord coord { get; set; }
        public List<Weather> weater { get; set; }
        public string @base { get; set; }
        public int visibility { get; set; }
        public int dt { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}
