using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeatherApp.Models
{
    public class DailyUnits
    {
        public string time {  get; set; }
        public string weather_code { get; set; }
        public string temperature_2m_max {  get; set; }
        public string temperature_2m_min { get; set; }
        public string precipitaion_probability_max { get; set; }
        
    }
}
