<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
=======
﻿namespace Eticaret.Core.Entities
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
{
    public class Marka : IEntity
    {
        public int Id { get; set; }
<<<<<<< HEAD
        [Display(Name = "Marka Adı")]
        public string Markaİsim { get; set; }
        [Display(Name = "Açıklama")]
        public string? Aciklama { get; set; }
        public string? Logo { get; set; }
        [Display(Name = "Aktif?")]
        public bool Aktif { get; set; }
        [Display(Name = "Sıra No")]
        public int SiralamaNo { get; set; }
        [Display(Name = "Kayıt Tarihi") ,ScaffoldColumn(false)]
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
=======
        public string Markaİsim { get; set; }
        public string? Aciklama { get; set; }
        public string? Logo { get; set; }
        public bool Aktif { get; set; }
        public int SiralamaNo { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
        public IList<Urun>? Urunler { get; set; }//bire çok ilişki bir markanın birden fazla ürünü olabili ve listeleleme

    }
}
