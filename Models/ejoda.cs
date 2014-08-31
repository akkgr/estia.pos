namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ejoda")]
    public partial class ejoda
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ejodaid { get; set; }

        [Required]
        [StringLength(50)]
        public string descr { get; set; }

        public DateTime imer { get; set; }

        [Column(TypeName = "money")]
        public decimal poso { get; set; }

        [Column(TypeName = "money")]
        public decimal fpa { get; set; }

        [StringLength(50)]
        public string tamias { get; set; }
    }
}
