using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace estia.pos.ViewModels
{
    public class Payment
    {
        public int FiveHundred { get; set; }
        public int OneHundred { get; set; }
        public int Fifty { get; set; }
        public int Twenty { get; set; }
        public int Ten { get; set; }
        public int Five { get; set; }
        public int Two { get; set; }
        public int One { get; set; }

        public decimal Total
        {
            get
            {
                return FiveHundred + OneHundred;
            }
        }
    }
}
