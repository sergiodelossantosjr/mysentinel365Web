using System;
using System.Collections.Generic;

namespace cpe05api.Models
{
    public partial class UserInfo
    {
        public System.Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
