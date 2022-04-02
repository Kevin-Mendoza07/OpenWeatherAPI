using Domain.Entities.ClimateInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IWeatherServices
    {
        Root GetWeather(string city);
        DateTime ConvertDateTime(long seconds);
        string GetImageWeather(string icon);
    }
}
