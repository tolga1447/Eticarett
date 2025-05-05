using Eticaret.Core.Entities;

namespace Eticaret.WebUI.Models
{
    public class SepetViewModel
    {
        public List<SepetLine> sepetLines {  get; set; }
        public decimal ToplamFiyat { get; set; }
    }
}
