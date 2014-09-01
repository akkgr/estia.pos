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
            payment = new Payment();

            this.Loaded += Window_Loaded;
        }
        
        private void findAccount(object sender, RoutedEventArgs e)
        {
            
            var s = (from p in db.XreosiPistosis
                     where p.appid == payment.AppId
                     select p.poso).Sum();

            payment.Dept = s;
        }

        private void findBarCode(object sender, RoutedEventArgs e)
        {

        }

        private void calcReturn(object sender, RoutedEventArgs e)
        {
            if (payment.Amount == 0) payment.Amount = payment.Dept;
            payment.Refound = payment.Total -  payment.Amount;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var buildingList = from b in db.Buildings
                               where b.Active == true
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
