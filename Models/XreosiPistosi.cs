namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XreosiPistosi")]
    public partial class XreosiPistosi
    {
        [Key]
        public int XP_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal appid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal poso { get; set; }

        [StringLength(500)]
        public string parathrhseis { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eidos_xp_id { get; set; }

        public DateTime hmer_XP { get; set; }

        public DateTime? log_hmer { get; set; }

        [StringLength(50)]
        public string byUser { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? contact_id { get; set; }

        public bool b_eksodo_idiokt { get; set; }

        [StringLength(255)]
        public string enoik_h_idiokt_onomatepon { get; set; }

        public bool b_isxyei { get; set; }

        public int? mhnas { get; set; }

        public int? etos { get; set; }

        public virtual XreosiPistosi_Eidos XreosiPistosi_Eidos { get; set; }
    }
}
