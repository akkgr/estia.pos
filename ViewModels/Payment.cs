using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace estia.pos.ViewModels
{
    public class Payment : INotifyPropertyChanged
    {
        public Payment()
        {
            Coins = new ObservableCollection<Coin>();
            Coins.Add(new Coin() { Amount = 500, Quantity = 0, Title="500 ευρώ" });
            Coins.Add(new Coin() { Amount = 200, Quantity = 0, Title = "200 ευρώ" });
            Coins.Add(new Coin() { Amount = 100, Quantity = 0, Title = "100 ευρώ" });
            Coins.Add(new Coin() { Amount = 50, Quantity = 0, Title = "50 ευρώ" });
            Coins.Add(new Coin() { Amount = 20, Quantity = 0, Title = "20 ευρώ" });
            Coins.Add(new Coin() { Amount = 10, Quantity = 0, Title = "10 ευρώ" });
            Coins.Add(new Coin() { Amount = 5, Quantity = 0, Title = "5 ευρώ" });
            Coins.Add(new Coin() { Amount = 2, Quantity = 0, Title = "2 ευρώ" });
            Coins.Add(new Coin() { Amount = 1, Quantity = 0, Title = "1 ευρώ" });
            Coins.Add(new Coin() { Amount = 0.5M, Quantity = 0, Title = "50 λεπτά" });
            Coins.Add(new Coin() { Amount = 0.2M, Quantity = 0, Title = "20 λεπτά" });
            Coins.Add(new Coin() { Amount = 0.1M, Quantity = 0, Title = "10 λεπτά" });
            Coins.Add(new Coin() { Amount = 0.05M, Quantity = 0, Title = "5 λεπτά" });
            Coins.Add(new Coin() { Amount = 0.02M, Quantity = 0, Title = "2 λεπτά" });
            Coins.Add(new Coin() { Amount = 0.01M, Quantity = 0, Title = "1 λεπτά" });

            foreach(var item in Coins)
            {
                item.PropertyChanged += item_PropertyChanged;
            }

        }

        void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged("Total");
        }

        public ObservableCollection<Coin> Coins { get; set; }

        private string searchOption;
        public string SearchOption
        {
            get
            {
                return searchOption;
            }
            set
            {
                if (value != searchOption)
                {
                    searchOption = value;
                    OnPropertyChanged("SearchOption");
                }
            }
        }

        public decimal Total
        {
            get
            {
                return Coins.Select(c=>c.Total).Sum();
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

        private string buildTitle;
        public string BuildTitle
        {
            get
            {
                return buildTitle;
            }
            set
            {
                if (value != buildTitle)
                {
                    buildTitle = value;
                    OnPropertyChanged("BuildTitle");
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

        private string appTitle;
        public string AppTitle
        {
            get
            {
                return appTitle;
            }
            set
            {
                if (value != appTitle)
                {
                    appTitle = value;
                    OnPropertyChanged("AppTitle");
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

    public class Coin : INotifyPropertyChanged
    {
        private string title;
        public string Title 
        {
            get
            {
                return title;
            }
            set
            {
                if (value != title)
                {
                    title = value;
                    OnPropertyChanged("title");
                }
            }
        }

        private int quantity;
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value != quantity)
                {
                    quantity = value;
                    OnPropertyChanged("Quantity");
                    OnPropertyChanged("Total");
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
                    OnPropertyChanged("Total");
                }
            }
        }

        public decimal Total
        {
            get
            {
                return amount * quantity;
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
