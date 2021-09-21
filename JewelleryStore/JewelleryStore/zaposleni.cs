namespace JewelleryStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("store_db.zaposleni")]
    public partial class zaposleni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zaposleni()
        {
            racuns = new HashSet<racun>();
        }

        [Key]
        public int idZaposlenog { get; set; }

        [Required]
        [StringLength(45)]
        public string Ime { get; set; }

        [Required]
        [StringLength(45)]
        public string Prezime { get; set; }

        [Required]
        [StringLength(45)]
        public string KorisnickoIme { get; set; }

        [Required]
        [StringLength(45)]
        public string Lozinka { get; set; }

        [Column(TypeName = "date")]
        public DateTime ZaposlenOd { get; set; }

        public decimal Plata { get; set; }

        public bool isAdmin { get; set; }

        public bool isActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<racun> racuns { get; set; }
    }
}
