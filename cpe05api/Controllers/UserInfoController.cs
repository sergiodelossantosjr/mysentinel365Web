using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using cpe05api.Models;
using cpe05api.Repository;
using Newtonsoft.Json;

namespace cpe05api.Controllers
{
  
    public class UserInfoController : ApiController
    {
        // GET api/values

        private UserInfoRepository _repository;

        public UserInfoController()
        {
                _repository = new UserInfoRepository();
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public UserInfo Get(string email, string password)
        {
            return _repository.LoginUserInfo(email, password);
        }

        // POST api/values
        public UserInfo Post(UserInfo info)
        {

            var result =  _repository.CreateUserInfo(info);

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
