using System.ComponentModel.DataAnnotations;

namespace Travel_V1.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter user name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter a valid password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
