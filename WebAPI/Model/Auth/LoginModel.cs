using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model.Auth
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required]
        public string ApplicationCode { get; set; }

        public string EmailOTP { get; set; }
    }
}
