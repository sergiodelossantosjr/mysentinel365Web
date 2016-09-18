using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using cpe05api.DTO;
//using System.Web.Mvc;
using cpe05api.Models;
using cpe05api.Repository;
using Newtonsoft.Json;

namespace cpe05api.Controllers
{
  
    public class WeatherController : ApiController
    {
        // GET api/values

        private WeatherRepository _repository;

        public WeatherController()
        {
            _repository = new WeatherRepository();
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //public UserInfo Get(string email, string password)
        //{
            //return _repository.LoginUserInfo(email, password);
        //}

        // POST api/values
        public Weather Post(Weather info)
        {

            var result =  _repository.CreateWeather(info);

            return result;
        }

        [Route("api/celcius")]
        [HttpGet]
        public List<CelciusDTO> Celcius()
        {
            var result = _repository.GetCelcius();

            return result;
        }
        [Route("api/fahrenheit")]
        [HttpGet]
        public List<FahrenheitDTO> Fahrenheit()
        {
            var result = _repository.GetFahrenheit();

            return result;
        }
        [Route("api/humidity")]
        [HttpGet]
        public List<HumidityDTO> Humidity()
        {
            var result = _repository.GetHumidity();

            return result;
        } 

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
