﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cpe05api.DTO
{
    public class HumidityDTO
    {
        public string humidity { get; set; }
        public string location { get; set; }
        public DateTime? createdon { get; set; }
    }
}