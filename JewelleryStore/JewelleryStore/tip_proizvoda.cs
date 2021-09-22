namespace JewelleryStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("store_db.tip_proizvoda")]
    public partial class tip_proizvoda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tip_proizvoda()
        {
            proizvods = new HashSet<proizvod>();
        }

        [Key]
        public int idTipaProizvoda { get; set; }

        [Required]
        [StringLength(45)]
        public string Tip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<proizvod> proizvods { get; set; }
    }
}
