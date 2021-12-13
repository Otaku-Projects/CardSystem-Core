namespace WebAPI.Model
{
    public class JwtBearerTokenSettings
    {
        public const string CONFIG_NAME = "JwtBearerTokenSettings";
        public string SecretKey { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int ExpiryTimeInSeconds { get; set; }
    }
}
