using Eticaret.Core.Entities;

namespace Eticaret.WebUI.Models
{
    public class HomePageViewModel
    {
        public List<Slider>Sliders { get; set; }
        public List<Urun> Urunler { get; set; }
        public List<Bildirim> Bildirimler { get; set; }
    }
}
