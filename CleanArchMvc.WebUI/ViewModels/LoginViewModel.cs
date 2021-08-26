
using System.ComponentModel.DataAnnotations;

namespace CleanArchMvc.WebUI.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Invalide Format email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, ErrorMessage ="The {0} must be at least {2} ant at max "+
            "{1} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
