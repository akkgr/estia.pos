namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KoinoxristaAnalyshDiamer")]
    public partial class KoinoxristaAnalyshDiamer
    {
        [Key]
        public int AnalKoinAppID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal appid { get; set; }

        public int mhnas { get; set; }

        public int etos { get; set; }

        public int CatID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? poso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? xiliosta_diam { get; set; }

        public int AnalKoinBuildID { get; set; }

        public int? sn { get; set; }

        public decimal epib_logo_klist { get; set; }

        public decimal? ei { get; set; }

        public decimal? fi { get; set; }

        public decimal? WRES_AYTONOMIAS { get; set; }

        public decimal? prohg_metr { get; set; }

        public decimal? torini_metr { get; set; }

        public virtual appartment appartment { get; set; }

        public virtual KoinoCat KoinoCat { get; set; }

        public virtual KoinoxristaAnalyshKtirio KoinoxristaAnalyshKtirio { get; set; }
    }
}
