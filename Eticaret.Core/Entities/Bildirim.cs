using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public class Bildirim : IEntity
    {
        public int Id { get; set; }
        public string İsim { get; set; }
<<<<<<< HEAD
        [Display(Name = "Açıklama")]
        public string? Aciklama { get; set; }
        
        public string? Resim { get; set; }
        [Display(Name = "Aktif?")]
        public bool Aktif { get; set; }
        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
=======
        public string? Aciklama { get; set; }
        public string? Resim { get; set; }
        public bool Aktif { get; set; }
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}
