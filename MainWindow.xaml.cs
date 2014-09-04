using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using estia.pos.Models;
using System.Data.Entity;
using System.Collections.ObjectModel;
using estia.pos.ViewModels;

namespace estia.pos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EstiaModel db;
        private Payment payment;
        public MainWindow()
        {
            InitializeComponent();

            db = new EstiaModel();
            payment = new Payment() { SearchOption="Page2"};
            pageOrder();
            this.Loaded += Window_Loaded;
            payment.PropertyChanged += payment_PropertyChanged;
            this.Wizard1.Next += Wizard1_Next;
        }

        void Wizard1_Next(object sender, Xceed.Wpf.Toolkit.Core.CancelRoutedEventArgs e)
        {
            if (this.Wizard1.CurrentPage == Page1)
            {
                if (payment.AppId == 0)
                {
                    e.Cancel = true;
                    return;
                }

                var q = from p in db.XreosiPistosis
                         where p.appid == payment.AppId
                         select p.poso;

                payment.BuildTitle = (this.BuildCombo.SelectedItem as Building).Title;
                payment.AppTitle = (this.AppCombo.SelectedItem as appartment).FullTitle;
                payment.Dept = q.Count()==0?0M:q.Sum();
            }
        }

        void payment_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("SearchOption"))
            {
                pageOrder();
            }
        }
        

        private void pageOrder()
        {
            if (payment.SearchOption.Equals("Page1"))
            {
                this.FirstPage.NextPage = this.Page1;
                this.Page3.PreviousPage = this.Page1;
            }
            else
            {
                this.FirstPage.NextPage = this.Page2;
                this.Page3.PreviousPage = this.Page2;
            }
        }
                
        private void calcReturn(object sender, RoutedEventArgs e)
        {
            if (payment.Amount == 0) payment.Amount = payment.Dept;
            payment.Refound = payment.Total -  payment.Amount;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var buildingList = from b in db.Buildings
                               where b.Active == true && b.Managment == 1
                               orderby b.Street, b.StreetNumber
                               select b;

            this.BuildCombo.ItemsSource = buildingList.ToList();
            this.DataContext = payment;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db.Dispose();
        } 
    }
}
