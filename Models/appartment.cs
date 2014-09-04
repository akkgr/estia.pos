namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class appartment
    {
        public appartment()
        {
            KoinoxristaAnalyshDiamers = new HashSet<KoinoxristaAnalyshDiamer>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal appid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal buildid { get; set; }

        [Required]
        [StringLength(50)]
        public string apptitle { get; set; }

        [StringLength(500)]
        public string ownerid { get; set; }

        [StringLength(500)]
        public string resedentid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? xkoino { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pkoino { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? xelev { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pelev { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ei { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? xowner { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? powner { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? xother { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pother { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? klisto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pklisto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? xther { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pther { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ektiposi { get; set; }

        [StringLength(500)]
        public string remowner { get; set; }

        [StringLength(500)]
        public string remresident { get; set; }

        [StringLength(500)]
        public string remappartment { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? eiboiler { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fiboiler { get; set; }

        public int? roleid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? xOther1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? xOther2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? xOther3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? xOther4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? xOther5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pOther1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pOther2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pOther3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pOther4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pOther5 { get; set; }

        public virtual Building Building { get; set; }

        public virtual ICollection<KoinoxristaAnalyshDiamer> KoinoxristaAnalyshDiamers { get; set; }

        public string FullTitle
        {
            get
            {
                return string.Format("{0} {1} {2}",apptitle,ownerid,resedentid);
            }
        }
    }
}
