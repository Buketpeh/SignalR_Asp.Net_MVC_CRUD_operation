namespace CrudCase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sati
    {
        [Key]
        public int satisno { get; set; }

        public int? aracno { get; set; }

        public int? musterino { get; set; }

        [Column(TypeName = "money")]
        public decimal? satisfiyat { get; set; }

        public DateTime satistarihi { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
