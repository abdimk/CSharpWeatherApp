using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeatherApp.Models
{
    public class Hourly
    {
        public List<string> time {  get; set; }
        public List<double> temperature_2m { get; set; }
        public List<double> precipitation_probability { get; set; }
        public List<int> weather_code { get; set; }
        public List<double> wind_speed_10m { get; set; }
        public List<int> is_day { get; set; } // was double and has setted to int

    }
}
