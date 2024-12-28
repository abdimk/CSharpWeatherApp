using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeatherApp.Models
{
    public class Daily
    {
        public List<string> time {  get; set; }
        public List<int> weather_code { get; set; }
        public List<double> temperature_2m_max { get; set; }
        public List<double> temperature_2m_min { get; set; }
        public List<double> precipitation_probability_max { get; set; }
        
    }
}
