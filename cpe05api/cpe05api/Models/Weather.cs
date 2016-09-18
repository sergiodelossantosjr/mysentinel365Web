using System;
using System.Collections.Generic;

namespace cpe05api.Models
{
    public partial class Weather
    {
        public System.Guid id { get; set; }
        public string humidity { get; set; }
        public string temperature_celcius { get; set; }
        public string temperature_fahrenheit { get; set; }
        public string location { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
    }
}
