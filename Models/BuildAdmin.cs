namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BuildAdmin
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal BuildAdminID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BuildID { get; set; }

        [Required]
        [StringLength(50)]
        public string AdmEponymo { get; set; }

        [StringLength(50)]
        public string AdmOnoma { get; set; }

        [StringLength(50)]
        public string AdmPatronymo { get; set; }

        [StringLength(50)]
        public string AdmAFM { get; set; }

        [StringLength(50)]
        public string AdmDOY { get; set; }

        [Required]
        [StringLength(50)]
        public string AdmThl { get; set; }

        [StringLength(50)]
        public string AdmKin { get; set; }

        [Required]
        [StringLength(50)]
        public string ParalEponymo { get; set; }

        [StringLength(50)]
        public string ParalOnoma { get; set; }

        [StringLength(50)]
        public string ParalThl { get; set; }

        [StringLength(2000)]
        public string Parathrhseis { get; set; }
    }
}
