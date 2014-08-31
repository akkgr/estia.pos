namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KoinoCat")]
    public partial class KoinoCat
    {
        public KoinoCat()
        {
            KoinoxristaAnalyshDiamers = new HashSet<KoinoxristaAnalyshDiamer>();
            KoinoxristaAnalyshKtirios = new HashSet<KoinoxristaAnalyshKtirio>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CatID { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        public virtual ICollection<KoinoxristaAnalyshDiamer> KoinoxristaAnalyshDiamers { get; set; }

        public virtual ICollection<KoinoxristaAnalyshKtirio> KoinoxristaAnalyshKtirios { get; set; }
    }
}
