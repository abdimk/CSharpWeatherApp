using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeatherApp.Models
{
    public class CurrentWeatherData
    {
        public double latitude {  get; set; }
        public double longitude { get; set; }
        public double generationtime_ms {  get; set; }
        public double utc_offset_seconds {  get; set; }
        public string timezone {  get; set; }
        public string timezone_abbreviation { get; set; }
        public string elevavtion { get; set; }
        public CurrentUnits current_units {  get; set; }
        public CurrentValues current {  get; set; }

    }
}
