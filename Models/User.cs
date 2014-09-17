namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(50)]
        public string Onoma { get; set; }

        [StringLength(50)]
        public string Eponymo { get; set; }

        [StringLength(50)]
        public string ThlEswt { get; set; }

        [StringLength(50)]
        public string ThlKatoikias { get; set; }

        [StringLength(50)]
        public string Kinhto { get; set; }

        [StringLength(500)]
        public string Dnsh { get; set; }

        [StringLength(50)]
        public string Polh { get; set; }

        public bool active { get; set; }

        public DateTime? hmer_energopoihshs { get; set; }

        public DateTime? last_logon { get; set; }

        public bool b_must_change_pass { get; set; }
    }
}
