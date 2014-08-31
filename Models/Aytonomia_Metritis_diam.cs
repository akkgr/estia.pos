namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aytonomia_Metritis_diam
    {
        public Aytonomia_Metritis_diam()
        {
            Aytonomia_analysh = new HashSet<Aytonomia_analysh>();
        }

        [Key]
        public int ayt_metritis_diam_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal appid { get; set; }

        [Required]
        [StringLength(50)]
        public string metritis_descr { get; set; }

        public int sn { get; set; }

        public DateTime date_added { get; set; }

        public virtual ICollection<Aytonomia_analysh> Aytonomia_analysh { get; set; }
    }
}
