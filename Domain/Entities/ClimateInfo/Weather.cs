using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.ClimateInfo
{
    public class Weather
    {
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
}
