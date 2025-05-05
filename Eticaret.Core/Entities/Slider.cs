<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
=======
﻿namespace Eticaret.Core.Entities
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
{
    public class Slider : IEntity
    {
        public int Id { get; set; }
<<<<<<< HEAD
        [Display(Name = "Başlık")]
        public string? Baslık { get; set; }
        [Display(Name = "Açıklama")]
=======
        public string? Baslık { get; set; }
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
        public string? Aciklama { get; set; }
        public string? Resim { get; set; }
        public string? Link { get; set; }

    }
}
