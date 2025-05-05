using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }//Eticaret.core (sınıf kütüphanesi) veritabınındaki verileri oluşturmak için yer alan bir sınıftır projenin temeli ve yapı taşıdır.
                                   //ve IEntity arabirimdir(İnterface) sınıflar arası iletişimi ilişkiyi sağlar.VARLIKTIR CORE KATMANI
    }
}
