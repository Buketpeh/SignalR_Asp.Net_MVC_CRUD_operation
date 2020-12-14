namespace CrudCase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musteri")]
    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            Alims = new HashSet<Alim>();
            Satis = new HashSet<Sati>();
        }

        [Key]
        public int musterino { get; set; }

        [Required]
        [StringLength(50)]
        public string musteriadi { get; set; }

        [Required]
        [StringLength(50)]
        public string musterisoyadi { get; set; }

        [StringLength(50)]
        public string musteriadres { get; set; }

        [StringLength(11)]
        public string musteritel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alim> Alims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sati> Satis { get; set; }
    }
}
