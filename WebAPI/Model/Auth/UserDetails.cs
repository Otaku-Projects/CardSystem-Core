using System;
using System.Collections.Generic;

namespace WebAPI.Model.Auth
{
    public class UserDetails
    {
        public string UserName { get; set; }
        public string NSUserId { get; set; }
        public List<string> Roles { get; set; }
        public List<string> Regions { get; set; }
        public string Factory { get; set; }
        public string UserId { get; set; }
    }
}
