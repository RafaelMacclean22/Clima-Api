using Clima_Api;

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
  public  class Clima
    {
        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }
        public class Main
        {
            public double temp { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }
        public class Sys
        {

            public int sunrise { get; set; }
            public int sunset { get; set; }
        }
        public class Weather
        {

            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        public class Wind
        {
            public double speed { get; set; }
        }

        public class root
        {
            public Coord coord { get; set; }
            public List<Weather> weather { get; set; }
            public  Main main { get; set; }
            public Wind wind { get; set; }
            public Sys sys { get; set; }
        }
    }
}
