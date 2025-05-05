<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
=======
﻿namespace Eticaret.Core.Entities
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
{
    public class AppUser : IEntity
    {

        public int Id { get; set; }
<<<<<<< HEAD
        
=======
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public string Email { get; set; }
        public string? Telefon { get; set; }
<<<<<<< HEAD
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string? KullaniciAdi { get; set; }
        [Display(Name ="Aktif?")]
        public bool Aktif { get; set; }
        [Display(Name ="Admin?")]
        public bool IsAdmin { get; set; }
        [Display(Name ="Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
        [ScaffoldColumn(false)]
        public Guid? KullaniciGuid { get; set; } = Guid.NewGuid();//guid öğren
        public List<Adres?>Adresler { get; set; }
=======
        public string Sifre { get; set; }
        public string? KullaniciAdi { get; set; } 
        public bool Aktif { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
        public Guid? KullaniciGuid { get; set; } = Guid.NewGuid();//guid öğren
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23

    }
}
