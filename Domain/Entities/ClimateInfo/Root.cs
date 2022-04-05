using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.ClimateInfo
{
    public class Root
    {
        public Coord Coord { get; set; }
        public List<Weather> Weather { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Sys Sys { get; set; }
        public Clouds Clouds { get; set; }

    }
}
