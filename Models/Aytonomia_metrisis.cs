namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aytonomia_metrisis
    {
        public Aytonomia_metrisis()
        {
            Aytonomia_analysh = new HashSet<Aytonomia_analysh>();
        }

        [Key]
        public int ayt_metr_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BuildID { get; set; }

        public DateTime? hmer_metrhshs { get; set; }

        public int? sn { get; set; }

        public bool? crnt { get; set; }

        public decimal? cm { get; set; }

        public decimal prohg_metr_cm { get; set; }

        public decimal torini_metr_cm { get; set; }

        public decimal prohg_metr_LT { get; set; }

        public decimal torini_metr_LT { get; set; }

        [StringLength(500)]
        public string comments { get; set; }

        public bool b_eggrafh_system { get; set; }

        public decimal? timi_litroy_agoras { get; set; }

        public decimal? mesi_timi_litroy { get; set; }

        public decimal? diafora_lt { get; set; }

        public decimal? kostos_fill { get; set; }

        public decimal? trexon_syn_kostos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BuildEjodaID { get; set; }

        public decimal? sum_litrwn { get; set; }

        public virtual ICollection<Aytonomia_analysh> Aytonomia_analysh { get; set; }
    }
}
