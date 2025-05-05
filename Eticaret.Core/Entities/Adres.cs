using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
{
    public class Adres : IEntity
    {
        public int Id { get; set; }
        [Display(Name ="Adres Başlığı"),Required(ErrorMessage = "{0} Alanı Zorunludur"), StringLength(50)]
        public string Title { get; set; }
        [Display(Name = "Şehir"),Required(ErrorMessage = "{0} Alanı Zorunludur"), StringLength(50)]
        public string Sehir { get; set; }
        [Display(Name = "İlçe"), Required(ErrorMessage = "{0} Alanı Zorunludur"), StringLength(50)]
        public string İlce { get; set; }
        [Display(Name = "Açık Adres"), Required(ErrorMessage = "{0} Alanı Zorunludur"), StringLength(50)]
        public string AcikAdres { get; set; }
        [Display(Name = "Aktif"), DataType(DataType.MultilineText),Required(ErrorMessage = "{0} Alanı Zorunludur")]
        public bool IsAktif { get; set; }
        [Display(Name = "Fatura Adresi")]
        public bool IsFaturaAdresi{ get; set; }
        [Display(Name = "Teslimat Adresi")]
        public bool IsTeslimatAdresi{ get; set; }
        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
        [ScaffoldColumn(false)]
        public Guid? AdresGuid { get; set; } = Guid.NewGuid();//guid öğren
        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }


    }
}
