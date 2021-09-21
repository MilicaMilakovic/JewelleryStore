namespace JewelleryStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("store_db.racun")]
    public partial class racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public racun()
        {
            racun_stavka = new HashSet<racun_stavka>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idRacuna { get; set; }

        public DateTime DatumIzdavanja { get; set; }

        public decimal CijenaUkupno { get; set; }

        public int ZAPOSLENI_idZaposlenog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<racun_stavka> racun_stavka { get; set; }

        public virtual zaposleni zaposleni { get; set; }
    }
}
