namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class XreosiPistosi_Eidos
    {
        public XreosiPistosi_Eidos()
        {
            XreosiPistosis = new HashSet<XreosiPistosi>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal eidos_xp_id { get; set; }

        [Required]
        [StringLength(50)]
        public string descr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal kostos { get; set; }

        public virtual ICollection<XreosiPistosi> XreosiPistosis { get; set; }
    }
}
