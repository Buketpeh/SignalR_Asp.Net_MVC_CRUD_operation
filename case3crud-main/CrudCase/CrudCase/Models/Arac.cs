namespace CrudCase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Arac")]
    public partial class Arac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arac()
        {
            Alims = new HashSet<Alim>();
            Satis = new HashSet<Sati>();
        }

        [Key]
        public int aracno { get; set; }

        [Required]
        [StringLength(20)]
        public string plaka { get; set; }

        [Required]
        [StringLength(50)]
        public string model { get; set; }

        [StringLength(20)]
        public string marka { get; set; }

        public int? fiyat { get; set; }

        public int? yas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alim> Alims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sati> Satis { get; set; }
    }
}
