using System;
namespace WebAPI.Models.Shared
{
    public class WebApiPath
    {
        public const string CONFIG_NAME = "WebapiPath";

        public string ADLoginPath { get; set; }
        public string NsApiPath { get; set; }
        public string NsApiPathKey { get; set; }
    }
}
