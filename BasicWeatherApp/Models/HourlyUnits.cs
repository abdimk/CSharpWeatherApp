using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeatherApp.Models
{
    public class HourlyUnits
    {
        public string time {  get; set; }
        public string temperature_2m { get; set; }
        public string precipitation_probability {  get; set; }
        public string weather_code { get; set; }
        public string wind_speed_10m { get; set; }
        public string is_day {  get; set; }



    }
}
