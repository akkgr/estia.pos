namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Eispraksei
    {
        [Key]
        public int EISPR_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string BAR_CODE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal APPID { get; set; }

        public DateTime HMER_XREVSHS { get; set; }

        public decimal POSO { get; set; }

        public DateTime? HMER_PLHRWMHS { get; set; }

        public int EISPRAKTORAS_USERID { get; set; }

        [Required]
        [StringLength(50)]
        public string EISPRAKTORAS { get; set; }

        public int TAMIAS_USERID { get; set; }

        [Required]
        [StringLength(50)]
        public string TAMIAS { get; set; }

        public bool B_PLHRWTHIKE { get; set; }

        public bool B_PLHRWMH_STO_GRAFEIO { get; set; }

        public bool B_AKYRH { get; set; }

        public int? XP_ID { get; set; }

        public decimal POSO_POY_EISPRAX8HKE { get; set; }
    }
}
