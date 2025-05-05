using System.ComponentModel.DataAnnotations;

namespace Eticaret.WebUI.Models
{
    public class KullaniciDuzenlemeView
    {
        public int Id { get; set; }
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public string Email { get; set; }
        public string? Telefon { get; set; }
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }
    }
}
