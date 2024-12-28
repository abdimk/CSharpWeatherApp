using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicWeatherApp.Models;
using BasicWeatherApp.Services;

namespace BasicWeatherApp
{
    public partial class Form1 : Form
    {
        private string latitude = "9.005401";
        private string longitude = "38.763611";

        private string siteUrl = "https://api.open-meteo.com/v1/forecast";

        private WeatherDataService _weatherDataService;
        public Form1()
        {
            InitializeComponent();

            _weatherDataService = new WeatherDataService();

            LoadCurrentWeatherData();
            LoadHourlyWeatherData();
            LoadDailyWeatherData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private async void LoadCurrentWeatherData()
        {
            string currentData = "temperature_2m,weather_code,apparent_temperature,is_day,relative_humidity_2m,dew_point_2m,rain,wind_speed_10m,snowfall,visibility";
            string currentEndpoint = "?latitude=" + latitude + "&longitude=" + longitude + "&current=" + currentData;
            
            //string mainurl = "https://api.open-meteo.com/v1/forecast?latitude=9.025&longitude=38.7469&hourly=temperature_2m,relative_humidity_2m,dew_point_2m,rain,snowfall,visibility,wind_speed_10m";
            string jsonString = await _weatherDataService.GetJsonString(siteUrl, currentEndpoint);

            CurrentWeatherData currentWeather = _weatherDataService.DeserializeCurrentWeatherData(jsonString);
            CurrentUnits currentUnits = currentWeather.current_units;
            CurrentValues currentValues = currentWeather.current;

            current_w_temp.Text = Math.Round(currentValues.temperature_2m) + " " + currentUnits.temperature_2m;
            apparent_temp.Text = "Feels Like " + Math.Round(currentValues.temperature_2m) + " " + currentUnits.apparent_temprature;
            current_humidity.Text = Math.Round(currentValues.relative_humidity_2m) + " " + currentUnits.relative_humidity_2m;
            current_drew_point.Text = Math.Round(currentValues.dew_point_2m) + " " + currentUnits.dew_point_2m;
            current_rain.Text = Math.Round(currentValues.rain) + " " + currentUnits.rain;
            current_wind_speed.Text = Math.Round(currentValues.wind_speed_10m) + " " + currentUnits.wind_speed_10m;
            current_snowfall.Text = Math.Round(currentValues.snowfall) + " " + currentUnits.snowfall;
            current_visibility.Text = Math.Round(currentValues.visibility) + " " + currentUnits.visibility;

            Dictionary<string, string> weatherInfo = _weatherDataService.GetWeatherDescriptions(currentValues.weather_code, currentValues.is_day);

            current_w_image.Load(weatherInfo["image"]);
            current_w_desc.Text = weatherInfo["description"];
            //MessageBox.Show(current_w_temp);
            //System.Diagnostics.Debug.WriteLine();

        }

        private async void LoadHourlyWeatherData()
        {
           // string currentData = "temperature_2m,weather_code,apparent_temperature,is_day,relative_humidity_2m,dew_point_2m,rain,wind_speed_10m,snowfall,visibility";
            string hourlyData = "temperature_2m,precipitation_probability,weather_code,wind_speed_10m,is_day";
            string hourlyEndpoint = "?latitude=" + latitude + "&longitude=" + longitude + "&hourly=" + hourlyData;

            string jsonString = await _weatherDataService.GetJsonString(siteUrl, hourlyEndpoint);

            HourlyWeatherData hourlyWeatherData = _weatherDataService.DeserializeHourlyWeatherData(jsonString);
            HourlyUnits hourlyUnits = hourlyWeatherData.hourly_units;
            Hourly hourly = hourlyWeatherData.hourly;

            List<string> time = hourly.time;
            List<double> temperature = hourly.temperature_2m;
            List<double> rain = hourly.precipitation_probability;
            List<int> code = hourly.weather_code;
            List<double> wind = hourly.wind_speed_10m;
            List<int> isDay = hourly.is_day;


            DateTime now = DateTime.Now; // Get the current date and time
            string currentHourString = now.ToString("yyyy-MM-ddTHH:00");

            int startIndex = time.IndexOf(currentHourString);

            if (startIndex == -1)
            {
                MessageBox.Show("Current hour not found in the List");
                return;
            }
            int count = Math.Min(24, time.Count - startIndex);

            int _xPos = 0;

            for(int j = startIndex; j < startIndex + count; j++)
            {
                Dictionary<string, string> weatherInfo = _weatherDataService.GetWeatherDescriptions(code.ElementAt(j), isDay.ElementAt(j));
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.ColumnCount = 1;
                tableLayoutPanel.RowCount = 6;
                tableLayoutPanel.Size = new Size(158, 235);
                tableLayoutPanel.Location = new Point(_xPos, 10);

                for(int i = 0; i < tableLayoutPanel.RowCount; i++)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle());
                }

                for(int i = 0; i < tableLayoutPanel.RowCount; i++)
                {
                    if(i == 1)
                    {
                        tableLayoutPanel.RowStyles[i].SizeType = SizeType.Absolute;
                        tableLayoutPanel.RowStyles[i].Height = 100;
                    } 
                    else if (i == 0 || i == 2)
                    {
                        tableLayoutPanel.RowStyles[i].SizeType = SizeType.Absolute;
                        tableLayoutPanel.RowStyles[i].Height = 25;
                    }
                }
                Label timeLabel = new Label();
                timeLabel.Text = time.ElementAt(j).Split('T')[1];
                timeLabel.Font = new Font("Arial", 10);
                timeLabel.ForeColor = Color.White;
                timeLabel.Margin = new Padding(3, 0, 3, 0);
                timeLabel.Dock = DockStyle.Fill;
                timeLabel.TextAlign = ContentAlignment.MiddleCenter;

                PictureBox imageBox = new PictureBox();
                imageBox.SizeMode = PictureBoxSizeMode.CenterImage;
                imageBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                imageBox.Margin = new Padding(20, 15, 0, 0);
                imageBox.Load(weatherInfo["image"]);

                Label tempLabel = new Label();
                tempLabel.Text = Math.Round(temperature.ElementAt(j)) + " " + hourlyUnits.temperature_2m;
                tempLabel.Font = new Font("Arial", 14, FontStyle.Bold);
                tempLabel.Margin = new Padding(0,3,0,3);
                tempLabel.ForeColor = Color.White;
                tempLabel.Dock = DockStyle.Fill;
                tempLabel.TextAlign = ContentAlignment.MiddleCenter;

                Label descriptionLabel = new Label();
                descriptionLabel.Text = weatherInfo["description"];
                descriptionLabel.Font = new Font("Arial", 12);
                descriptionLabel.Margin = new Padding(0,3,0,3);
                descriptionLabel.ForeColor = Color.White;
                descriptionLabel.Dock = DockStyle.Fill;
                descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;


                Label rainLabel = new Label();
                rainLabel.Text = "Rain - " + Math.Round(rain.ElementAt(j)) + " " + hourlyUnits.precipitation_probability;
                rainLabel.Font = new Font("Arial", 8);
                rainLabel.Margin = new Padding(0, 3, 0, 3);
                rainLabel.ForeColor = Color.White;
                rainLabel.Dock = DockStyle.Fill;
                rainLabel.TextAlign = ContentAlignment.MiddleCenter;

                Label windSpeedLabel = new Label();
                windSpeedLabel.Text = "Wind Speed - " + Math.Round(wind.ElementAt(j)) + " " + hourlyUnits.wind_speed_10m;
                windSpeedLabel.Font = new Font("Arial", 9);
                windSpeedLabel.Margin = new Padding(0, 3, 0, 3);
                windSpeedLabel.ForeColor = Color.White;
                windSpeedLabel.Dock = DockStyle.Fill;
                windSpeedLabel.TextAlign = ContentAlignment.TopCenter;

                tableLayoutPanel.Controls.Add(timeLabel, 0, 0);
                tableLayoutPanel.Controls.Add(imageBox, 0, 1);
                tableLayoutPanel.Controls.Add(tempLabel, 0, 2);
                tableLayoutPanel.Controls.Add(descriptionLabel, 0, 3);
                tableLayoutPanel.Controls.Add(rainLabel, 0, 4);
                tableLayoutPanel.Controls.Add(windSpeedLabel, 0, 5);

                hourly_panel.Controls.Add(tableLayoutPanel);

                _xPos += 156;


            }




            //MessageBox.Show(jsonString);
        }

        private async void LoadDailyWeatherData()
        {
            // string currentData = "temperature_2m,weather_code,apparent_temperature,is_day,relative_humidity_2m,dew_point_2m,rain,wind_speed_10m,snowfall,visibility";
            //string hourlyData = "temperature_2m,precipitation_probability,weather_code,wind_speed_10m,is_day";
            //string hourlyEndpoint = "?latitude=" + latitude + "&longitude=" + longitude + "&hourly=" + hourlyData;

            string dailyData = "weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max";
            string dailyEndpoint = "?latitude=" + latitude + "&longitude=" + longitude + "&daily=" + dailyData;
            string jsongString = await _weatherDataService.GetJsonString(siteUrl, dailyEndpoint);

            // MessageBox.Show(jsongString);

            DailyWeatherData dailyWeatherData = _weatherDataService.DeserializeDailyWeatherData(jsongString);

            List<string> time = dailyWeatherData.daily.time;
            List<double> preProbability = dailyWeatherData.daily.precipitation_probability_max;
            List<int> weatherCode = dailyWeatherData.daily.weather_code;
            List<double> maxTemp = dailyWeatherData.daily.temperature_2m_max;
            List<double> minTemp = dailyWeatherData.daily.temperature_2m_min;

            int _yPos = 7;
            for(int j = 0; j < 7; j++)
            {
                TableLayoutPanel dailyTableLayoutPanel = new TableLayoutPanel();
                dailyTableLayoutPanel.RowCount = 1;
                dailyTableLayoutPanel.ColumnCount = 5;
                dailyTableLayoutPanel.Size = new Size(550, 100);
                dailyTableLayoutPanel.Location = new Point(0, _yPos);


                for(int i =0; i < dailyTableLayoutPanel.ColumnCount; i++)
                {
                    dailyTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
                }

                for(int i = 0; i < dailyTableLayoutPanel.ColumnCount; i++)
                {
                    dailyTableLayoutPanel.ColumnStyles[i].SizeType = SizeType.Percent;
                    dailyTableLayoutPanel.ColumnStyles[i].Width = 20;

                }

                Label dayLabel = new Label();
                string dayOfTheWeek = GetDayofWeekFromDateString(time.ElementAt(j));
                dayLabel.Text = dayOfTheWeek;
                dayLabel.Font = new Font("Arial", 12,FontStyle.Bold);
                dayLabel.Margin = new Padding(3, 0, 3, 0);
                dayLabel.ForeColor = Color.White;
                dayLabel.Dock = DockStyle.Fill;
                dayLabel.TextAlign = ContentAlignment.MiddleCenter;


                Label rainLabel = new Label();
                rainLabel.Text = "Rain - " + Math.Round(preProbability.ElementAt(j)) + " " + dailyWeatherData.daily_units.precipitaion_probability_max;
                rainLabel.Font = new Font("Arial", 10);
                rainLabel.Margin = new Padding(3, 0, 3, 0);
                rainLabel.ForeColor = Color.White;
                rainLabel.Dock = DockStyle.Fill;
                rainLabel.TextAlign = ContentAlignment.MiddleCenter;


                // Load the Image

                Dictionary<string, string> weatherInfo = _weatherDataService.GetWeatherDescriptions(weatherCode.ElementAt(j), 1);
                PictureBox imageBox = new PictureBox();
                imageBox.Margin = new Padding(0, 28, 0, 0);
                imageBox.SizeMode = PictureBoxSizeMode.CenterImage;
                imageBox.Load(weatherInfo["image"]);


                //maxTemp label
                Label maxTempLabel = new Label();
                maxTempLabel.Text = Math.Round(maxTemp.ElementAt(j)) + " " + dailyWeatherData.daily_units.temperature_2m_max;
                maxTempLabel.Font = new Font("Arial", 14, FontStyle.Bold);
                maxTempLabel.Margin = new Padding(3, 0, 3, 0);
                maxTempLabel.Dock = DockStyle.Fill;
                maxTempLabel.TextAlign = ContentAlignment.MiddleCenter;


                //minTemp label 
                Label minTempLabel = new Label();
                minTempLabel.Text = Math.Round(minTemp.ElementAt(j)) + " " + dailyWeatherData.daily_units.temperature_2m_min;
                minTempLabel.Font = new Font("Arial", 14, FontStyle.Bold);
                minTempLabel.Margin = new Padding(3, 0, 3, 0);
                minTempLabel.ForeColor = Color.White;
                minTempLabel.Dock = DockStyle.Fill;
                minTempLabel.TextAlign = ContentAlignment.MiddleCenter;

                dailyTableLayoutPanel.Controls.Add(dayLabel, 0, 0);
                dailyTableLayoutPanel.Controls.Add(rainLabel, 1, 0);
                dailyTableLayoutPanel.Controls.Add(imageBox, 2, 0);
                dailyTableLayoutPanel.Controls.Add(maxTempLabel, 3, 0);
                dailyTableLayoutPanel.Controls.Add(minTempLabel, 4, 0);

                daily_panel.Controls.Add(dailyTableLayoutPanel);

                _yPos += 100;


            }
        }

        public string GetDayofWeekFromDateString(string dateString)
        {
            DateTime date = DateTime.Parse(dateString);
            return date.DayOfWeek.ToString();

        }



    }
}
