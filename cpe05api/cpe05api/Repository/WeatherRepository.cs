using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using cpe05api.DTO;
using cpe05api.Models;

namespace cpe05api.Repository
{
    public class WeatherRepository : IWeather
    {
        private cpe05Context _context;
        public WeatherRepository()
        {
                _context = new cpe05Context();
        }

        public List<CelciusDTO> GetCelcius()
        {
            try
            {
                return _context.Weathers.Select(x => new CelciusDTO()
                {
                    temperature_celcius = x.temperature_celcius,
                    location = x.location,
                    createdon = x.createdon
                }).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<FahrenheitDTO> GetFahrenheit()
        {
            try
            {
                return _context.Weathers.Select(x => new FahrenheitDTO()
                {
                    temperature_fahrenheit = x.temperature_fahrenheit,
                    location = x.location,
                    createdon = x.createdon
                }).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<HumidityDTO> GetHumidity()
        {
            try
            {
                return _context.Weathers.Select(x => new HumidityDTO()
                {
                    humidity = x.humidity,
                    location = x.location,
                    createdon = x.createdon
                }).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 

        public Weather CreateWeather(Weather weatherInfo)
        {
            try
            {
                Weather _weather = new Weather()
                {
                    id = Guid.NewGuid(),
                    humidity = weatherInfo.humidity,
                    temperature_celcius = weatherInfo.temperature_celcius,
                    temperature_fahrenheit = weatherInfo.temperature_fahrenheit,
                    location = weatherInfo.location,
                    createdon = DateTime.Now
                };

                var weather = _context.Weathers.Add(_weather);

                _context.SaveChanges();

               return weather;

            }
            catch (Exception ex)
            {
                    
                throw ex;
            }
        }
    }
}