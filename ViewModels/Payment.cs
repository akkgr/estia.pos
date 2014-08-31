using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace estia.pos.ViewModels
{
    public class Payment : INotifyPropertyChanged
    {
        private int fh;
        public int FiveHundred { 
            get 
            { 
                return fh; 
            } 
            set 
            {
                if (value != fh)
                {
                    fh = value;
                    OnPropertyChanged("FiveHundred");
                    OnPropertyChanged("Total");
                }
            } 
        }

        private int oh;
        public int OneHundred
        {
            get
            {
                return oh;
            }
            set
            {
                if (value != oh)
                {
                    oh = value;
                    OnPropertyChanged("OneHundred");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int fifty;
        public int Fifty
        {
            get
            {
                return fifty;
            }
            set
            {
                if (value != fifty)
                {
                    fifty = value;
                    OnPropertyChanged("Fifty");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int twenty;
        public int Twenty
        {
            get
            {
                return twenty;
            }
            set
            {
                if (value != twenty)
                {
                    twenty = value;
                    OnPropertyChanged("Twenty");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int ten;
        public int Ten
        {
            get
            {
                return ten;
            }
            set
            {
                if (value != ten)
                {
                    ten = value;
                    OnPropertyChanged("Ten");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int five;
        public int Five
        {
            get
            {
                return five;
            }
            set
            {
                if (value != five)
                {
                    five = value;
                    OnPropertyChanged("Five");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int two;
        public int Two
        {
            get
            {
                return two;
            }
            set
            {
                if (value != two)
                {
                    two = value;
                    OnPropertyChanged("Two");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int one;
        public int One
        {
            get
            {
                return one;
            }
            set
            {
                if (value != one)
                {
                    one = value;
                    OnPropertyChanged("One");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int onecent;
        public int OneCent
        {
            get
            {
                return onecent;
            }
            set
            {
                if (value != onecent)
                {
                    onecent = value;
                    OnPropertyChanged("OneCent");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int twocents;
        public int TwoCents
        {
            get
            {
                return twocents;
            }
            set
            {
                if (value != twocents)
                {
                    twocents = value;
                    OnPropertyChanged("TwoCents");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int fivecents;
        public int FiveCents
        {
            get
            {
                return fivecents;
            }
            set
            {
                if (value != fivecents)
                {
                    fivecents = value;
                    OnPropertyChanged("FiveCents");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int tencents;
        public int TenCents
        {
            get
            {
                return tencents;
            }
            set
            {
                if (value != tencents)
                {
                    tencents = value;
                    OnPropertyChanged("FiveCents");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int twentycents;
        public int TwentyCents
        {
            get
            {
                return twentycents;
            }
            set
            {
                if (value != twentycents)
                {
                    twentycents = value;
                    OnPropertyChanged("TwentyCents");
                    OnPropertyChanged("Total");
                }
            }
        }

        private int fiftycents;
        public int FiftyCents
        {
            get
            {
                return fiftycents;
            }
            set
            {
                if (value != fiftycents)
                {
                    fiftycents = value;
                    OnPropertyChanged("FiftyCents");
                    OnPropertyChanged("Total");
                }
            }
        }

        public decimal Total
        {
            get
            {
                return fh * 500 + oh * 100 + fifty * 50 + twenty * 20 + ten * 10 + five * 5 + two * 2 + one
                    + fiftycents * 0.5M + twentycents * 0.2M + tencents / 0.1M + twocents *0.02M + onecent * 0.01M;
            }
        }

        private decimal dept;
        public Decimal Dept
        {
            get
            {
                return dept;
            }
            set
            {
                if (value != dept)
                {
                    dept = value;
                    OnPropertyChanged("Dept");
                }
            }
        }

        private decimal amount;
        public Decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value != amount)
                {
                    amount = value;
                    OnPropertyChanged("Amount");
                }
            }
        }

        private decimal refound;
        public Decimal Refound
        {
            get
            {
                return refound;
            }
            set
            {
                if (value != refound)
                {
                    refound = value;
                    OnPropertyChanged("Refound");
                }
            }
        }

        private decimal buildid;
        public decimal BuildId
        {
            get
            {
                return buildid;
            }
            set
            {
                if (value != buildid)
                {
                    buildid = value;
                    OnPropertyChanged("BuildId");
                }
            }
        }

        private decimal appid;
        public decimal AppId
        {
            get
            {
                return appid;
            }
            set
            {
                if (value != appid)
                {
                    appid = value;
                    OnPropertyChanged("AppId");
                }
            }
        }

        private string barcode;
        public string Barcode
        {
            get
            {
                return barcode;
            }
            set
            {
                if (value != barcode)
                {
                    barcode = value;
                    OnPropertyChanged("Barcode");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
