using Domain.Entities.ClimateInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IWeatherModel
    {
        Root GetWeather(string city);
        DateTime ConvertDateTime(long seconds);
        string GetImageWeather(string icon);
    }
}
