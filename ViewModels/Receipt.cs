using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace estia.pos.ViewModels
{
    public class Receipt
    {
        public string XP_ID {get; set;}
        
        public string building {get; set;}
        
        public string apartment {get; set;}
        
        public string resident {get; set;}
        
        public string owner {get; set;}
        
        public DateTime hmeromhnia {get; set;}

        public decimal poso { get; set; }
    }
}
