namespace JewelleryStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("store_db.proizvod")]
    public partial class proizvod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public proizvod()
        {
            racun_stavka = new HashSet<racun_stavka>();
        }

        [Key]
        public int SifraProizvoda { get; set; }

        [Required]
        [StringLength(45)]
        public string Naziv { get; set; }

        public decimal Cijena { get; set; }

        public int Kolicina { get; set; }

        [StringLength(150)]
        public string Slika { get; set; }

        [StringLength(45)]
        public string Opis { get; set; }

        public bool? isActive { get; set; }

        public int tipProizvoda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<racun_stavka> racun_stavka { get; set; }

        public virtual tip_proizvoda tip_proizvoda { get; set; }
    }
}
