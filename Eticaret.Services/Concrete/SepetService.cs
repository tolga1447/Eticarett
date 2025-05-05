using Eticaret.Core.Entities;
using Eticaret.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Services.Concrete
{
    public class SepetService : ISepetService
    {
        public List<SepetLine> SepetLines=new ();
        public void AddUrun(Urun urunler, int quantity)
        {
            var urun = SepetLines.FirstOrDefault(u => u.urun.Id == urunler.Id);
            if (urun != null) 
            {
                urun.Quantity += quantity;
            }
            else
            {
                SepetLines.Add(new SepetLine
                {
                    Quantity = quantity,
                    urun = urunler
                });
            }

        }

        public void RemoveUrun(Urun urun)
        {
            SepetLines.RemoveAll(u => u.urun.Id == urun.Id);
        }

        public void SepetTemizle()
        {
            SepetLines.Clear();
        }

        public decimal ToplamFiyat()
        {
            return SepetLines.Sum(c=>c.urun.UrunFiyat * c.Quantity);
        }

        public void UpdateUrun(Urun urunler, int quantity)
        {
            var urun = SepetLines.FirstOrDefault(u => u.urun.Id == urunler.Id);
            if (urun != null)
            {
                urun.Quantity = quantity;
            }
            else
            {
                SepetLines.Add(new SepetLine
                {
                    Quantity = quantity,
                    urun = urunler
                });
            }
        }
    }
}
