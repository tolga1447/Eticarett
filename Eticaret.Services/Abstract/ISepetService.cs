using Eticaret.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Services.Abstract
{
    public interface ISepetService
    {
        void AddUrun(Urun urun,int quantity);
        void UpdateUrun(Urun urun,int quantity);
        void RemoveUrun(Urun urun);
        decimal ToplamFiyat();
        void SepetTemizle();
    }
}
