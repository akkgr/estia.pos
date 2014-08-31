namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tameio")]
    public partial class Tameio
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal tameioID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? buildID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? APPID { get; set; }

        public DateTime? HMER_KOINOXR { get; set; }

        public int? ETOS { get; set; }

        public int? MHNAS { get; set; }

        public decimal POSO { get; set; }

        public DateTime HMER_TAMEIOU { get; set; }

        public int Emp_USERID { get; set; }

        [Required]
        [StringLength(50)]
        public string Emp_USER { get; set; }

        public int app_USERID { get; set; }

        [Required]
        [StringLength(50)]
        public string app_USER { get; set; }

        public bool B_PLHRWTHIKE { get; set; }

        public bool B_PLHRWMH_STO_GRAFEIO { get; set; }

        public bool B_AKYRH { get; set; }

        [StringLength(500)]
        public string buildTitle { get; set; }

        [StringLength(10)]
        public string AppTitle { get; set; }

        [StringLength(500)]
        public string owner { get; set; }

        [StringLength(500)]
        public string resident { get; set; }

        [StringLength(50)]
        public string barcode { get; set; }

        public DateTime? HMER_CLOSE { get; set; }
    }
}
