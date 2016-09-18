using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using cpe05api.Models;

namespace cpe05api.Repository
{
    public class UserInfoRepository : IUserInfo
    {
        private cpe05Context _context;
        public UserInfoRepository()
        {
                _context = new cpe05Context();
        }

        public UserInfo CreateUserInfo(UserInfo userInfo)
        {
            try
            {
                UserInfo _user = new UserInfo()
                {
                    Id = Guid.NewGuid(),
                    Firstname = userInfo.Firstname,
                    Middlename = userInfo.Middlename,
                    Lastname = userInfo.Lastname,
                    Email = userInfo.Email,
                    Password = userInfo.Password
                };

                var user = _context.UserInfoes.Add(_user);

                _context.SaveChanges();

               return user;

            }
            catch (Exception ex)
            {
                    
                throw ex;
            }
        }


        public UserInfo LoginUserInfo(string email, string password)
        {
            try
            {
                UserInfo user = _context.UserInfoes
                    .FirstOrDefault(x => x.Email == email && x.Password == password);

                return user;
            }
            catch (Exception)
            {
                    
                throw;
            }
        }
    }
}