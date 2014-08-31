namespace estia.pos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KoinoxrostaMynhmata")]
    public partial class KoinoxrostaMynhmata
    {
        [Key]
        public int MsgID { get; set; }

        public int BuildID { get; set; }

        public int mhnas { get; set; }

        public int etos { get; set; }

        [Required]
        [StringLength(2000)]
        public string Msg { get; set; }
    }
}
