namespace CrudCase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alim")]
    public partial class Alim
    {
        [Key]
        public int alimno { get; set; }

        public int? aracno { get; set; }

        [Column(TypeName = "money")]
        public decimal? aracfiyat { get; set; }

        public DateTime alimtarihi { get; set; }

        public int? musterino { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
