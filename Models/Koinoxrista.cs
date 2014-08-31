namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Koinoxrista")]
    public partial class Koinoxrista
    {
        [Column(TypeName = "numeric")]
        public decimal buildid { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal appid { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime ekdosh { get; set; }

        [Column(TypeName = "money")]
        public decimal? ownerposo { get; set; }

        [Column(TypeName = "money")]
        public decimal? residentposo { get; set; }

        public DateTime? ownerdate { get; set; }

        public DateTime? residentdate { get; set; }
    }
}
