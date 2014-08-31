namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("esoda")]
    public partial class esoda
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal esodaid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? buildid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? workid { get; set; }

        [Column(TypeName = "money")]
        public decimal? poso { get; set; }

        [Column(TypeName = "money")]
        public decimal? fpa { get; set; }

        [Column(TypeName = "money")]
        public decimal? ergatika { get; set; }

        public DateTime? imer { get; set; }
    }
}
