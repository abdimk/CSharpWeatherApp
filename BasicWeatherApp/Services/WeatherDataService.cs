using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BasicWeatherApp.Models;
using Newtonsoft.Json;

namespace BasicWeatherApp.Services
{
    public class WeatherDataService
    {
        private Dictionary<string, WeatherDescription> weatherDescriptionMap;

        public WeatherDataService()
        {
            InitializeWeatherDescriptionMap();
        }

        private void InitializeWeatherDescriptionMap()
        {
            string jsonContent = @"{

    ""0"": {
        ""day"": {
            ""description"": ""Sunny"",
            ""image"": ""http://openweathermap.org/img/wn/01d@2x.png""
        },
        ""night"": {
            ""description"": ""Clear"",
            ""image"": ""http://openweathermap.org/img/wn/01n@2x.png""
        }
    },
    ""1"": {
        ""day"": {
            ""description"": ""Mainly Sunny"",
            ""image"": ""http://openweathermap.org/img/wn/01d@2x.png""
        },
        ""night"": {
            ""description"": ""Mainly Clear"",
            ""image"": ""http://openweathermap.org/img/wn/01n@2x.png""
        }
    },
    ""2"": {
        ""day"": {
            ""description"": ""Partly Cloudy"",
            ""image"": ""http://openweathermap.org/img/wn/02d@2x.png""
        },
        ""night"": {
            ""description"": ""Partly Cloudy"",
            ""image"": ""http://openweathermap.org/img/wn/02n@2x.png""
        }
    },
    ""3"": {
        ""day"": {
            ""description"": ""Cloudy"",
            ""image"": ""http://openweathermap.org/img/wn/03d@2x.png""
        },
        ""night"": {
            ""description"": ""Cloudy"",
            ""image"": ""http://openweathermap.org/img/wn/03n@2x.png""
        }
    },
    ""45"": {
        ""day"": {
            ""description"": ""Foggy"",
            ""image"": ""http://openweathermap.org/img/wn/50d@2x.png""
        },
        ""night"": {
            ""description"": ""Foggy"",
            ""image"": ""http://openweathermap.org/img/wn/50n@2x.png""
        }
    },
    ""48"": {
        ""day"": {
            ""description"": ""Rime Fog"",
            ""image"": ""http://openweathermap.org/img/wn/50d@2x.png""
        },
        ""night"": {
            ""description"": ""Rime Fog"",
            ""image"": ""http://openweathermap.org/img/wn/50n@2x.png""
        }
    },
    ""51"": {
        ""day"": {
            ""description"": ""Light Drizzle"",
            ""image"": ""http://openweathermap.org/img/wn/09d@2x.png""
        },
        ""night"": {
            ""description"": ""Light Drizzle"",
            ""image"": ""http://openweathermap.org/img/wn/09n@2x.png""
        }
    },
    ""53"": {
        ""day"": {
            ""description"": ""Drizzle"",
            ""image"": ""http://openweathermap.org/img/wn/09d@2x.png""
        },
        ""night"": {
            ""description"": ""Drizzle"",
            ""image"": ""http://openweathermap.org/img/wn/09n@2x.png""
        }
    },
    ""55"": {
        ""day"": {
            ""description"": ""Heavy Drizzle"",
            ""image"": ""http://openweathermap.org/img/wn/09d@2x.png""
        },
        ""night"": {
            ""description"": ""Heavy Drizzle"",
            ""image"": ""http://openweathermap.org/img/wn/09n@2x.png""
        }
    },
    ""56"": {
        ""day"": {
            ""description"": ""Light Freezing Drizzle"",
            ""image"": ""http://openweathermap.org/img/wn/09d@2x.png""
        },
        ""night"": {
            ""description"": ""Light Freezing Drizzle"",
            ""image"": ""http://openweathermap.org/img/wn/09n@2x.png""
        }
    },
    ""57"": {
        ""day"": {
            ""description"": ""Freezing Drizzle"",
            ""image"": ""http://openweathermap.org/img/wn/09d@2x.png""
        },
        ""night"": {
            ""description"": ""Freezing Drizzle"",
            ""image"": ""http://openweathermap.org/img/wn/09n@2x.png""
        }
    },
    ""61"": {
        ""day"": {
            ""description"": ""Light Rain"",
            ""image"": ""http://openweathermap.org/img/wn/10d@2x.png""
        },
        ""night"": {
            ""description"": ""Light Rain"",
            ""image"": ""http://openweathermap.org/img/wn/10n@2x.png""
        }
    },
    ""63"": {
        ""day"": {
            ""description"": ""Rain"",
            ""image"": ""http://openweathermap.org/img/wn/10d@2x.png""
        },
        ""night"": {
            ""description"": ""Rain"",
            ""image"": ""http://openweathermap.org/img/wn/10n@2x.png""
        }
    },
    ""65"": {
        ""day"": {
            ""description"": ""Heavy Rain"",
            ""image"": ""http://openweathermap.org/img/wn/10d@2x.png""
        },
        ""night"": {
            ""description"": ""Heavy Rain"",
            ""image"": ""http://openweathermap.org/img/wn/10n@2x.png""
        }
    },
    ""66"": {
        ""day"": {
            ""description"": ""Light Freezing Rain"",
            ""image"": ""http://openweathermap.org/img/wn/10d@2x.png""
        },
        ""night"": {
            ""description"": ""Light Freezing Rain"",
            ""image"": ""http://openweathermap.org/img/wn/10n@2x.png""
        }
    },
    ""67"": {
        ""day"": {
            ""description"": ""Freezing Rain"",
            ""image"": ""http://openweathermap.org/img/wn/10d@2x.png""
        },
        ""night"": {
            ""description"": ""Freezing Rain"",
            ""image"": ""http://openweathermap.org/img/wn/10n@2x.png""
        }
    },
    ""71"": {
        ""day"": {
            ""description"": ""Light Snow"",
            ""image"": ""http://openweathermap.org/img/wn/13d@2x.png""
        },
        ""night"": {
            ""description"": ""Light Snow"",
            ""image"": ""http://openweathermap.org/img/wn/13n@2x.png""
        }
    },
    ""73"": {
        ""day"": {
            ""description"": ""Snow"",
            ""image"": ""http://openweathermap.org/img/wn/13d@2x.png""
        },
        ""night"": {
            ""description"": ""Snow"",
            ""image"": ""http://openweathermap.org/img/wn/13n@2x.png""
        }
    },
    ""75"": {
        ""day"": {
            ""description"": ""Heavy Snow"",
            ""image"": ""http://openweathermap.org/img/wn/13d@2x.png""
        },
        ""night"": {
            ""description"": ""Heavy Snow"",
            ""image"": ""http://openweathermap.org/img/wn/13n@2x.png""
        }
    },
    ""77"": {
        ""day"": {
            ""description"": ""Snow Grains"",
            ""image"": ""http://openweathermap.org/img/wn/13d@2x.png""
        },
        ""night"": {
            ""description"": ""Snow Grains"",
            ""image"": ""http://openweathermap.org/img/wn/13n@2x.png""
        }
    },
    ""80"": {
        ""day"": {
            ""description"": ""Light Showers"",
            ""image"": ""http://openweathermap.org/img/wn/09d@2x.png""
        },
        ""night"": {
            ""description"": ""Light Showers"",
            ""image"": ""http://openweathermap.org/img/wn/09n@2x.png""
        }
    },
    ""81"": {
        ""day"": {
            ""description"": ""Showers"",
            ""image"": ""http://openweathermap.org/img/wn/09d@2x.png""
        },
        ""night"": {
            ""description"": ""Showers"",
            ""image"": ""http://openweathermap.org/img/wn/09n@2x.png""
        }
    },
    ""82"": {
        ""day"": {
            ""description"": ""Heavy Showers"",
            ""image"": ""http://openweathermap.org/img/wn/09d@2x.png""
        },
        ""night"": {
            ""description"": ""Heavy Showers"",
            ""image"": ""http://openweathermap.org/img/wn/09n@2x.png""
        }
    },
    ""85"": {
        ""day"": {
            ""description"": ""Light Snow Showers"",
            ""image"": ""http://openweathermap.org/img/wn/13d@2x.png""
        },
        ""night"": {
            ""description"": ""Light Snow Showers"",
            ""image"": ""http://openweathermap.org/img/wn/13n@2x.png""
        }
    },
    ""86"": {
        ""day"": {
            ""description"": ""Snow Showers"",
            ""image"": ""http://openweathermap.org/img/wn/13d@2x.png""
        },
        ""night"": {
            ""description"": ""Snow Showers"",
            ""image"": ""http://openweathermap.org/img/wn/13n@2x.png""
        }
    },
    ""95"": {
        ""day"": {
            ""description"": ""Thunderstorm"",
            ""image"": ""http://openweathermap.org/img/wn/11d@2x.png""
        },
        ""night"": {
            ""description"": ""Thunderstorm"",
            ""image"": ""http://openweathermap.org/img/wn/11n@2x.png""
        }
    },
    ""96"": {
        ""day"": {
            ""description"": ""Light Thunderstorms With Hail"",
            ""image"": ""http://openweathermap.org/img/wn/11d@2x.png""
        },
        ""night"": {
            ""description"": ""Light Thunderstorms With Hail"",
            ""image"": ""http://openweathermap.org/img/wn/11n@2x.png""
        }
    },
    ""99"": {
        ""day"": {
            ""description"": ""Thunderstorm With Hail"",
            ""image"": ""http://openweathermap.org/img/wn/11d@2x.png""
        },
        ""night"": {
            ""description"": ""Thunderstorm With Hail"",
            ""image"": ""http://openweathermap.org/img/wn/11n@2x.png""
        }
    }

}";
            weatherDescriptionMap = JsonConvert.DeserializeObject<Dictionary<string, WeatherDescription>>(jsonContent);
        }

        public Dictionary<string, string> GetWeatherDescriptions(double weather_code, int is_day)
        {
            Dictionary<string, string> info = new Dictionary<string, string>();
            string indexString = weather_code.ToString();

            if (weatherDescriptionMap.TryGetValue(indexString, out WeatherDescription description))
            {
                if (is_day == 1)
                {
                    info["description"] = description.day.description;
                    info["image"] = description.day.image;
                }
                else
                {
                    info["description"] = description.night.description;
                    info["image"] = description.night.image;
                }
            }
            else
            {
                // Fallback to default description if not found
                if (weatherDescriptionMap.TryGetValue("0", out WeatherDescription defaultDescription))
                {
                    if (is_day == 1)
                    {
                        info["description"] = defaultDescription.day.description;
                        info["image"] = defaultDescription.day.image;
                    }
                    else
                    {
                        info["description"] = defaultDescription.night.description;
                        info["image"] = defaultDescription.night.image;
                    }
                }
            }

            return info;
        }

        // Other existing methods...

        public CurrentWeatherData DeserializeCurrentWeatherData(string json)
        {
            return JsonConvert.DeserializeObject<CurrentWeatherData>(json);
        }

        public HourlyWeatherData DeserializeHourlyWeatherData(string json)
        {
            return JsonConvert.DeserializeObject<HourlyWeatherData>(json);
        }

        public DailyWeatherData DeserializeDailyWeatherData(string json)
        {
            return JsonConvert.DeserializeObject<DailyWeatherData>(json);
        }

        public async Task<string> GetJsonString(string siteUrl, string endPoint)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(siteUrl);

                HttpResponseMessage response = await client.GetAsync(endPoint);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }

                return "Could not retrieve JSON object";
            }
        }
    }

    // Additional classes to support the weather description mapping
    public class WeatherDescription
    {
        public WeatherDescriptionDetail day { get; set; }
        public WeatherDescriptionDetail night { get; set; }
    }

    public class WeatherDescriptionDetail
    {
        public string description { get; set; }
        public string image { get; set; }
    }
}