﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cpe05api.Models;

namespace cpe05api.Repository
{
    public interface IWeather
    {
        Weather CreateWeather(Weather weather);
    }
}
