namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aytonomia_analysh
    {
        [Key]
        public int Ayt_anal_id { get; set; }

        public int ayt_metritis_diam_id { get; set; }

        public int ayt_metr_id { get; set; }

        public DateTime hmer_log { get; set; }

        public int sn { get; set; }

        public decimal prohg_metr { get; set; }

        public decimal torini_metr { get; set; }

        public decimal mesi_timi_litroy { get; set; }

        public decimal ei { get; set; }

        public decimal fi { get; set; }

        public decimal wres { get; set; }

        public decimal ei_wres { get; set; }

        public decimal sum_ei_wres { get; set; }

        public decimal ei_fi { get; set; }

        public decimal sum_ei_fi { get; set; }

        public decimal analogia_pagioy { get; set; }

        public decimal analogia_wrwn { get; set; }

        public decimal synolo { get; set; }

        public bool b_included_in_koinoxrista { get; set; }

        public decimal? sumores { get; set; }

        public virtual Aytonomia_metrisis Aytonomia_metrisis { get; set; }

        public virtual Aytonomia_Metritis_diam Aytonomia_Metritis_diam { get; set; }
    }
}
