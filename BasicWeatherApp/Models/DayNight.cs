using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeatherApp.Models
{
    public class DayNight
    {
        public WeatherInfo day {  get; set; }
        public WeatherInfo night { get; set; }
    }
}
