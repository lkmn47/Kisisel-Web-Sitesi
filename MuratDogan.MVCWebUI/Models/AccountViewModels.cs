using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MuratDogan.MVCWebUI.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "E-posta")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [Display(Name = "Beni anımsa?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-posta")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Parolayı onaylayın")]
        [Compare("Password", ErrorMessage = "Parola ve onay parolası aynı değil.")]
        public string ConfirmPassword { get; set; }
    }

}
