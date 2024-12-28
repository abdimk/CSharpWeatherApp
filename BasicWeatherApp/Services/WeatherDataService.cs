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

                return "Could not retrive JSON object";
            }
        }


        public Dictionary<string, string> GetWeatherDescriptions(double weather_code, int is_day)
        {
            Dictionary<string, string> info = new Dictionary<string, string>();
            string jsonFilePath = "C:\\Users\\user\\Desktop\\Final Csh project\\BasicWeatherApp\\BasicWeatherApp\\weather_discription.json";

            string jsonString = File.ReadAllText(jsonFilePath);

            WeatherForcast forcast = JsonConvert.DeserializeObject<WeatherForcast>(jsonString);

            string indexString = weather_code.ToString();

            if(forcast != null)
            {
                var forcastType = typeof(WeatherForcast);
                var dayNightProperty = forcastType.GetProperty($"Day{indexString}");

                DayNight dayNight = (DayNight)dayNightProperty.GetValue(forcast);

                if(dayNightProperty != null)
                {
                    if(dayNight != null)
                    {
                        if(is_day == 1)
                        {
                            info["description"] = dayNight.day.description;
                            info["image"] = dayNight.day.image; 
                        }
                        else
                        {
                            info["description"] = dayNight.night.description;
                            info["image"] = dayNight.night.image;

                        }
                    }
                }
                else
                {
                    dayNightProperty = forcastType.GetProperty("Day0");
                    dayNight = (DayNight)dayNightProperty.GetValue (forcast);

                    if(is_day == 1)
                    {
                        info["description"] = dayNight.day.description;
                        info["image"] = dayNight.day.image;

                    }
                    else
                    {
                        info["description"] = dayNight.night.description;
                        info["image"] = dayNight.night.image;

                    }
                }
            }

            return info;
        }



    }
}
