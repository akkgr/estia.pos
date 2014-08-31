namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BuildEjoda")]
    public partial class BuildEjoda
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal BuildEjodaID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BuildID { get; set; }

        public DateTime? LogDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? poso { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ContactID { get; set; }

        public DateTime? ActDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? workid { get; set; }

        public int? CatID { get; set; }

        [StringLength(2000)]
        public string parathrhseis { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? posotita { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? timh_ana_litro { get; set; }

        [StringLength(50)]
        public string eidos_plhrwmhs { get; set; }

        public DateTime? ora_apo { get; set; }

        public DateTime? ora_eos { get; set; }

        public bool? b_ekkremotita { get; set; }

        public DateTime? hmer_oloklhrosis_ergasias { get; set; }

        public DateTime? hmer_enhmerosis_et { get; set; }

        public DateTime? hmer_ektyposis { get; set; }

        public DateTime? hmer_programmatismoy_erg { get; set; }

        public bool? b_lock { get; set; }

        [StringLength(50)]
        public string epibarynsh { get; set; }

        public bool? b_symetoxh_se_fpa { get; set; }

        public DateTime? hmer_ekdosis_koino { get; set; }

        [StringLength(50)]
        public string EidosParastatikou { get; set; }

        [StringLength(50)]
        public string ArParastatikou { get; set; }

        public DateTime? ParalaviParastatikou { get; set; }

        public DateTime? SeArxeio { get; set; }

        public DateTime? SeTrapeza { get; set; }

        public DateTime? DateParastatikou { get; set; }

        public virtual WorkCategory WorkCategory { get; set; }
    }
}
