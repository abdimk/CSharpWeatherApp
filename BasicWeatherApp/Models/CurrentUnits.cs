using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeatherApp.Models
{
    public class CurrentUnits
    {
        public string time {  get; set; }
        public string interval { get; set; }
        public string temperature_2m { get; set; }
        public string weather_code { get; set; }
        public string apparent_temprature { get; set; }
        public string is_day {  get; set; }
        public string relative_humidity_2m { get; set; }
        public string dew_point_2m { get; set; }
        public string rain {  get; set; }
        public string wind_speed_10m { get; set; }
        public string snowfall {  get; set; }
        public string visibility { get; set; }

    }
}
