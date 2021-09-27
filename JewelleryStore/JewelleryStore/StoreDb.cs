using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace JewelleryStore
{
    public partial class StoreDb : DbContext
    {
        public StoreDb()
            : base("name=StoreDb3")
        {
        }

        public virtual DbSet<proizvod> proizvods { get; set; }
        public virtual DbSet<racun> racuns { get; set; }
        public virtual DbSet<racun_stavka> racun_stavka { get; set; }
        public virtual DbSet<tip_proizvoda> tip_proizvoda { get; set; }
        public virtual DbSet<zaposleni> zaposlenis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<proizvod>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<proizvod>()
                .Property(e => e.Slika)
                .IsUnicode(false);

            modelBuilder.Entity<proizvod>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<proizvod>()
                .HasMany(e => e.racun_stavka)
                .WithRequired(e => e.proizvod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<racun>()
                .HasMany(e => e.racun_stavka)
                .WithRequired(e => e.racun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tip_proizvoda>()
                .Property(e => e.Tip)
                .IsUnicode(false);

            modelBuilder.Entity<tip_proizvoda>()
                .HasMany(e => e.proizvods)
                .WithRequired(e => e.tip_proizvoda)
                .HasForeignKey(e => e.tipProizvoda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.KorisnickoIme)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .Property(e => e.Lozinka)
                .IsUnicode(false);

            modelBuilder.Entity<zaposleni>()
                .HasMany(e => e.racuns)
                .WithRequired(e => e.zaposleni)
                .HasForeignKey(e => e.ZAPOSLENI_idZaposlenog)
                .WillCascadeOnDelete(false);
        }
    }
}
