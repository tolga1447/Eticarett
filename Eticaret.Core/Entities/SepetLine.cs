using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public class SepetLine
    {
        public int Id { get; set; }
        public Urun urun { get; set; }
        public int Quantity { get; set; }//Quantity: sepetteki miktari
    }
}
