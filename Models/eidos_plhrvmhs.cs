namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class eidos_plhrvmhs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_eidos_plhrwmhs { get; set; }

        [Required]
        [StringLength(50)]
        public string descr { get; set; }

        public int? sn { get; set; }
    }
}
