namespace JewelleryStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("store_db.racun_stavka")]
    public partial class racun_stavka
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SifraProizvoda { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idRacuna { get; set; }

        public int Kolicina { get; set; }

        public decimal Cijena { get; set; }

        public virtual proizvod proizvod { get; set; }

        public virtual racun racun { get; set; }

    }
}
