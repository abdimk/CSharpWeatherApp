using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BasicWeatherApp.Services
{
    internal class GeoCoding
    {
        private static readonly HttpClient httpClient;
        private const string API_KEY = "3c28237da14bfcc408023c582d339f4a"; // Replace with your OpenWeatherMap API key

        static GeoCoding()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "BasicWeatherApp/1.0 (rabadormelba@gmail.com)");
        }

        public async Task<(double Latitude, double Longitude)> GetCoordinatesAsync(string city, string country)
        {
            // Construct the request URL for OpenWeatherMap Geocoding API
            string requestUrl = $"https://api.openweathermap.org/geo/1.0/direct?q={Uri.EscapeDataString(city + "," + country)}&limit=1&appid={API_KEY}";

            try
            {
                // Send the request
                var response = await httpClient.GetStringAsync(requestUrl);
                var json = JArray.Parse(response);

                // Check if the response contains results
                if (json.Count > 0)
                {
                    double latitude = (double)json[0]["lat"];
                    double longitude = (double)json[0]["lon"];
                    return (latitude, longitude);
                }
                else
                {
                    throw new Exception("Unable to get coordinates. No results found.");
                }
            }
            catch (HttpRequestException e)
            {
                throw new Exception("Error fetching data from the geocoding service: " + e.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }
    }
}
