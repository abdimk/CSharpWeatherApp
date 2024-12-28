using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BasicWeatherApp.Models
{
    public class WeatherForcast
    {
        [JsonProperty("0")]
        public DayNight Day0 { get; set; }

        [JsonProperty("1")]
        public DayNight Day1 { get; set; }

        [JsonProperty("2")]
        public DayNight Day2 { get; set; }

        [JsonProperty("3")]
        public DayNight Day3 { get; set; }

        [JsonProperty("45")]
        public DayNight Day45 { get; set; }

        [JsonProperty("48")]
        public DayNight Day48 { get; set; }

        [JsonProperty("51")]
        public DayNight Day51 { get; set; }

        [JsonProperty("53")]
        public DayNight Day53 { get; set; }

        [JsonProperty("55")]
        public DayNight Day55 { get; set; }

        [JsonProperty("56")]
        public DayNight Day56 { get; set; }

        [JsonProperty("57")]
        public DayNight Day57 { get; set; }

        [JsonProperty("61")]
        public DayNight Day61 { get; set; }

        [JsonProperty("63")]
        public DayNight Day63 { get; set; }

        [JsonProperty("65")]
        public DayNight Day65 { get; set; }

        [JsonProperty("66")]
        public DayNight Day66 { get; set; }

        [JsonProperty("67")]
        public DayNight Day67 { get; set; }

        [JsonProperty("71")]
        public DayNight Day71 { get; set; }

        [JsonProperty("73")]
        public DayNight Day73 { get; set; }

        [JsonProperty("75")]
        public DayNight Day75 { get; set; }

        [JsonProperty("77")]
        public DayNight Day77 { get; set; }

        [JsonProperty("80")]
        public DayNight Day80 { get; set; }

        [JsonProperty("81")]
        public DayNight Day081 { get; set; }

        [JsonProperty("85")]
        public DayNight Day85 { get; set; }

        [JsonProperty("86")]
        public DayNight Day86 { get; set; }

        [JsonProperty("95")]
        public DayNight Day95 { get; set; }

        [JsonProperty("96")]
        public DayNight Day96 { get; set; }

        [JsonProperty("99")]
        public DayNight Day99 { get; set; }
    }
}
