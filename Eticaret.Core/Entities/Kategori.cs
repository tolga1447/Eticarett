<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
=======
﻿namespace Eticaret.Core.Entities
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
{
    public class Kategori : IEntity
    {
        public int Id { get; set; }
<<<<<<< HEAD
        [Display(Name = "Kategori Adı")]
        public string Kategoriİsim { get; set; }
        [Display(Name = "Açıklama")]
        public string? Aciklama { get; set; }
        

        public string? Resim { get; set; }
        [Display(Name = "Aktif?")]
        public bool Aktif { get; set; }
        [Display(Name = "Üst Menüde Göster")]
        public bool UstMenu { get; set; }
        [Display(Name = "Üst Kategori")]
        public int AnaMenuId { get; set; }
        [Display(Name = "Sıra No")]
        public int SiralamaNo { get; set; }
        [Display(Name = "Kayıt Tarihi") ,ScaffoldColumn(false)]
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
=======
        public string Kategoriİsim { get; set; }
        public string? Aciklama { get; set; }
        public string? Resim { get; set; }
        public bool Aktif { get; set; }
        public bool UstMenu { get; set; }
        public int AnaMenuId { get; set; }
        public int SiralamaNo { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
        public IList<Urun>? Urunler { get; set; }//bire çok ilişki bir kategorinin birden fazla ürünü olabili ve listeleleme
    }
}
