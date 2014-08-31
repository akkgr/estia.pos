namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trapeza")]
    public partial class Trapeza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int trapeza_id { get; set; }

        [Required]
        [StringLength(200)]
        public string descr { get; set; }

        [StringLength(200)]
        public string code { get; set; }
    }
}
