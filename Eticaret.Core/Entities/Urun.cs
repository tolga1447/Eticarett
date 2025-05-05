using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public class Urun : IEntity
    {
        public int Id { get; set; }
<<<<<<< HEAD
        [Display(Name = "Ürün İsim")]
        public string Urunİsim { get; set; }
        [Display(Name = "Açıklama")]
        public string? Aciklama { get; set; }
        
        public string? Resim { get; set; }
        [Display(Name = "Ürün Fiyatı")]
        public decimal UrunFiyat { get; set; }
        [Display(Name = "Ürün Kodu")]
        public string? UrunKodu { get; set; }
        [Display(Name = "Ürün Stok Miktarı")]
        public  int StokMiktari { get; set; }
        [Display(Name = "Aktif?")]
        public bool Aktif { get; set; }
        [Display(Name = "Anasayfada Göster")]
        public bool AnaSayfa { get; set; }//bir ürün checkboxta true işaretlenirse ana sayfada gözüksün.
        [Display(Name = "Kategori")]
        public int? KategoriId { get; set; }
        [Display(Name = "Kategori")]
        public  Kategori? Kategori { get; set; }
        [Display(Name = "Marka")]
        public int? MarkaId { get; set; }
        [Display(Name = "Marka")]
        public  Marka? Marka { get; set; }//listelenmesi için null soru işareti
        [Display(Name = "Sıra No")]
        public int SiralamaNo { get; set; }
        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
=======
        public string Urunİsim { get; set; }
        public string? Aciklama { get; set; }
        public string? Resim { get; set; }
        public decimal UrunFiyat { get; set; }
        public string? UrunKodu { get; set; }
        public  int StokMiktari { get; set; }
        public bool Aktif { get; set; }
        public bool AnaSayfa { get; set; }//bir ürün checkboxta true işaretlenirse ana sayfada gözüksün.
        public int? KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public int? MarkaId { get; set; }
        public Marka Marka { get; set; }
        public int SiralamaNo { get; set; }

        public DateTime OlusturmaTarihi { get; set; }
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
    }


}

