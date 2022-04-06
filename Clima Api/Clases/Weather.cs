using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherAPI.Domain.Entities.Climate
{
    public class Weather
    {
   
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
}
