using Eticaret.Core.Entities;

namespace Eticaret.WebUI.Models
{
    public class CheckoutViewModel
    {
        public List<SepetLine> SepetUrun { get; set; }
        public decimal ToplamFiyat { get; set; }
    }
}
