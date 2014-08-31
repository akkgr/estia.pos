namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Building
    {
        public Building()
        {
            appartments = new HashSet<appartment>();
            KoinoxristaAnalyshKtirios = new HashSet<KoinoxristaAnalyshKtirio>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal BuildID { get; set; }

        [Required]
        [StringLength(100)]
        public string Area { get; set; }

        [Required]
        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(10)]
        public string StreetNumber { get; set; }

        [StringLength(10)]
        public string TK { get; set; }

        [Column(TypeName = "text")]
        public string Remarks { get; set; }

        [StringLength(50)]
        public string DEHnum { get; set; }

        public DateTime? DEHdate { get; set; }

        [StringLength(50)]
        public string EYDAPnum { get; set; }

        public DateTime? EYDAPdate { get; set; }

        [StringLength(50)]
        public string Gasnum { get; set; }

        public DateTime? Gasdate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Apothematiko { get; set; }

        public int? tiposthermansis { get; set; }

        [Column(TypeName = "money")]
        public decimal? PetreleoDejamenis { get; set; }

        public int? Managment { get; set; }

        [StringLength(50)]
        public string KodHlekPlhr { get; set; }

        [StringLength(500)]
        public string eponimia_DEY { get; set; }

        [StringLength(500)]
        public string eponimia_EYDAP { get; set; }

        [StringLength(500)]
        public string eponimia_FA { get; set; }

        [StringLength(500)]
        public string ar_paroxhs_DEH { get; set; }

        [StringLength(500)]
        public string ar_mhtrooy_EYDAP { get; set; }

        [StringLength(500)]
        public string kodikos_plhromhs_FA { get; set; }

        public bool paralabh_graf_DEH { get; set; }

        public bool paralabh_graf_EYDAP { get; set; }

        public bool paralabh_graf_FA { get; set; }

        public decimal litra_ana_cm { get; set; }

        public bool? ThermoWres { get; set; }

        public bool Active { get; set; }

        public virtual ICollection<appartment> appartments { get; set; }

        public virtual ICollection<KoinoxristaAnalyshKtirio> KoinoxristaAnalyshKtirios { get; set; }

        public string Title { get { return string.Format("{1} {2}, {0}", Area, Street, StreetNumber); } }
    }
}
