using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.ClimateInfo
{
    public class Sys
    {
        public string country { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }
    }
}
