using System.ComponentModel.DataAnnotations;

namespace Eticaret.WebUI.Models
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress),Required(ErrorMessage ="Email Alanı Zorunludur.")]
        public string Email { get; set; }
        [Display(Name = "Şifre")]
        [DataType(DataType.Password), Required(ErrorMessage = "Şifre Alanı Zorunludur.")]
        public string Sifre { get; set; }
        public string? ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}
