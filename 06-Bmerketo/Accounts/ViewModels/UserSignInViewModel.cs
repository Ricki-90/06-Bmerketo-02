using System.ComponentModel.DataAnnotations;

namespace _06_Bmerketo.Accounts.ViewModels
{
    public class UserSignInViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "You must provide a Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;


        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must provide a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Display(Name = "Keep me logged in")]
        public bool RememberMe { get; set; } = false;
    }
}
