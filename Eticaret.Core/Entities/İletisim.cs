<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
{
    public class Iletisim : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public string İsim { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public string Soyisim { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez")]
        public string Mesaj { get; set; }
        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
        [Display(Name = "Okundu Bilgisi")]
        public bool Okundu { get; set; } = false;
=======
﻿namespace Eticaret.Core.Entities
{
    public class İletisim : IEntity
    {
        public int Id { get; set; }
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        public string Mesaj { get; set; }
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;



>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23

    }
}
