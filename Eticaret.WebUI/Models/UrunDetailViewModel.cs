using Eticaret.Core.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Eticaret.WebUI.Models
{
    public class UrunDetailViewModel
    {
        public Urun? Urun{ get; set; }
        public IEnumerable<Urun>? İliskiliUrunler{ get; set; } // List<Urun> ?'da kullanabiliriz list işlemine gerek varsa
    }
}
