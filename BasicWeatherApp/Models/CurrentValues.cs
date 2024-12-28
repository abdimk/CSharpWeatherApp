using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeatherApp.Models
{
    public class CurrentValues
    {
        public string time {  get; set; }
        public double interval { get; set; }
        public double temperature_2m { get; set; }
        public double weather_code { get; set; }
        public double apparent_temperature { get; set; }
        public int is_day { get; set; }
        public double relative_humidity_2m {  get; set; }
        public double dew_point_2m {  get; set; }
        public double rain {  get; set; }
        public double wind_speed_10m { get; set; }
        public double snowfall {  get; set; }
        public double visibility { get; set; }

    }
}
