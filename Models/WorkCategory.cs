namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkCategory
    {
        public WorkCategory()
        {
            BuildEjodas = new HashSet<BuildEjoda>();
            Contacts = new HashSet<Contact>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal workid { get; set; }

        [Required]
        [StringLength(50)]
        public string worktitle { get; set; }

        public bool menu_visibile { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sn { get; set; }

        public bool b_programatismos_apo_grafeio { get; set; }

        public virtual ICollection<BuildEjoda> BuildEjodas { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
