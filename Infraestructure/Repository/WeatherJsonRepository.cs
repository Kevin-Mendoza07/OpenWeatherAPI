using Domain.Entities.ClimateInfo;
using Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net;

namespace Infraestructure.Repository
{
    public class WeatherJsonRepository : IWeatherModel
    {
        private Root rootinfo;
        private const string APIKey = "54a2d385952f88418fef91a13d5ac22d";
        private const string units = "metric";

        public Root GetWeather(string city)
        {
            using (WebClient webClient = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units={2}", city, APIKey,units);
                var json = webClient.DownloadString(url);

                rootinfo = JsonConvert.DeserializeObject<Root>(json);

                return rootinfo;
            }
        }

        public string GetImageWeather(string icon)
        {
            string image = "https://openweathermap.org/img/w/"+icon+".png";

            return image;
        }

        public DateTime ConvertDateTime(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();
            return day;
        }
    }
}


