using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cpe05api.DTO
{
    public class FahrenheitDTO
    {
        public string temperature_fahrenheit { get; set; }
        public string location { get; set; }
        public DateTime? createdon { get; set; }
    }
}