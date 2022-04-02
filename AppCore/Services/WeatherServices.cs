using AppCore.Interfaces;
using Domain.Entities.ClimateInfo;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class WeatherServices : IWeatherServices
    {

        private IWeatherModel weatherModel;

        public WeatherServices(IWeatherModel weatherModel)
        {
            this.weatherModel = weatherModel;
        }

        public DateTime ConvertDateTime(long seconds)
        {
            return weatherModel.ConvertDateTime(seconds);
        }

        public string GetImageWeather(string icon)
        {
            return weatherModel.GetImageWeather(icon);
        }

        public Root GetWeather(string city)
        {
            return weatherModel.GetWeather(city);
        }
    }
}
