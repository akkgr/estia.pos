namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KoinoxristaAnalyshKtirio")]
    public partial class KoinoxristaAnalyshKtirio
    {
        public KoinoxristaAnalyshKtirio()
        {
            KoinoxristaAnalyshDiamers = new HashSet<KoinoxristaAnalyshDiamer>();
        }

        [Key]
        public int AnalKoinBuildID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BuildID { get; set; }

        public int mhnas { get; set; }

        public int etos { get; set; }

        public int CatID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? poso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sum_xiliosta_kathgorias { get; set; }

        public int? sn { get; set; }

        [StringLength(2000)]
        public string comments { get; set; }

        public virtual Building Building { get; set; }

        public virtual KoinoCat KoinoCat { get; set; }

        public virtual ICollection<KoinoxristaAnalyshDiamer> KoinoxristaAnalyshDiamers { get; set; }
    }
}
