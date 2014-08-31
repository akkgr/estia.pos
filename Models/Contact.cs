namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ContactID { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WorkID { get; set; }

        [StringLength(50)]
        public string PhoneHome { get; set; }

        [StringLength(50)]
        public string PhoneMoblie { get; set; }

        [StringLength(50)]
        public string PhoneWork { get; set; }

        [StringLength(50)]
        public string PhoneFax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [Column(TypeName = "text")]
        public string Remarks { get; set; }

        public decimal? pososto_prom { get; set; }

        public int? trapeza_id { get; set; }

        [StringLength(200)]
        public string trapeza_account { get; set; }

        [StringLength(9)]
        public string AFM { get; set; }

        [StringLength(200)]
        public string IBAN { get; set; }

        public virtual WorkCategory WorkCategory { get; set; }
    }
}
