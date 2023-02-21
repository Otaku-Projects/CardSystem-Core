using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model.Auth
{
    public class AuthInfo
    {
        public string AccessToken { get; set; }
        public List<RouteInfo> Routes { get; set; }
        public bool TwoFA { get; set; }
        public bool ForgotPassword { get; set; }
        public string ErrorMessage { get; set; }
    }
}
