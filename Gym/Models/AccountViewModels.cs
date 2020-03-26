using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gym.Models
{


    public class LoginViewModel
    {
        [Required]
        [Display(Name = "البريد الالكترونى")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "الرقم السرى")]
        public string Password { get; set; }

        [Display(Name = "تذكرنى ؟")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "البريد الالكترونى")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "الرقم السرى")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تأكيد الرقم السرى")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

}
