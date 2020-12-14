namespace CrudCase.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Threading.Tasks;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Alim> Alims { get; set; }
        public virtual DbSet<Arac> Aracs { get; set; }
        public virtual DbSet<Musteri> Musteris { get; set; }
        public virtual DbSet<Sati> Satis { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alim>()
                .Property(e => e.aracfiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Arac>()
                .Property(e => e.plaka)
                .IsUnicode(false);

            modelBuilder.Entity<Arac>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<Arac>()
                .Property(e => e.marka)
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.musteriadi)
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.musterisoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.musteriadres)
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.musteritel)
                .IsUnicode(false);

            modelBuilder.Entity<Sati>()
                .Property(e => e.satisfiyat)
                .HasPrecision(19, 4);
        }

        internal Task SaveChangeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
