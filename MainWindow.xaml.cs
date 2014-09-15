﻿using System;
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
            setContext(true);
            pageOrder();
            this.Loaded += Window_Loaded;            
            this.Wizard1.Next += Wizard1_Next;
            this.Wizard1.Cancel += Wizard1_Cancel;
            this.Wizard1.Finish += Wizard1_Finish;
        }

        private void setContext(bool first)
        {
            if (!first) payment.PropertyChanged -= payment_PropertyChanged;
            payment = new Payment() { SearchOption = "Page2", PayAll = true };
            payment.PropertyChanged += payment_PropertyChanged;
            this.DataContext = payment;
        }

        void Wizard1_Finish(object sender, RoutedEventArgs e)
        {
            if (payment.Amount == 0) return;
            MessageBoxResult result = MessageBox.Show("Τυπώθηκε η Απόδειξη;", "Πληρωμή Λογαριασμού", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            Tameio tamio = new Tameio();
            tamio.buildID = payment.BuildId;
            tamio.buildTitle = payment.BuildTitle;
            tamio.APPID = payment.AppId;
            tamio.AppTitle = payment.AppTitle;
            //tamio.HMER_KOINOXR = clsKoinoxrhsta.GetLastKoinoDate(drTameio.APPID)
            //tamio.ETOS = drTameio.HMER_KOINOXR.Year
            //tamio.MHNAS = drTameio.HMER_KOINOXR.Month
            tamio.HMER_TAMEIOU =DateTime.Now.Date;
            tamio.POSO = payment.Amount;
            //tamio.app_USERID = myUser.UserID
            //tamio.app_USER = myUser.Usename
            //tamio.Emp_USERID = myUser.UserID
            //tamio.Emp_USER = myUser.Usename
            tamio.B_PLHRWTHIKE = false;
            tamio.B_PLHRWMH_STO_GRAFEIO = true;
            tamio.B_AKYRH = false;
            tamio.barcode = tamio.buildID.ToString().PadLeft(5, '0') +
                        tamio.ETOS.ToString() +
                        tamio.POSO.ToString("0000") +
                        tamio.MHNAS.ToString().PadLeft(2, '0') +
                        tamio.APPID.ToString().PadLeft(5, '0');
            tamio.owner = payment.Owner;
            tamio.resident = payment.Resident;

            XreosiPistosi xp = new XreosiPistosi();
            xp.appid = payment.AppId;
            xp.b_isxyei = true;
            xp.b_eksodo_idiokt = false;
            xp.eidos_xp_id = 100;
            xp.enoik_h_idiokt_onomatepon = payment.AppTitle;
            xp.hmer_XP = DateTime.Now.Date;
            xp.log_hmer = DateTime.Now;
            xp.byUser = "";
            xp.parathrhseis = "ΠΛΗΡΩΜΗ ΣΤΟ ΓΡΑΦΕΙΟ";
            xp.poso = - payment.Amount;
            xp.mhnas = tamio.MHNAS;
            xp.etos = tamio.ETOS;

            if (result == MessageBoxResult.Yes)
            {
                setContext(false);
                this.Wizard1.CurrentPage = this.FirstPage;
            }
        }

        void Wizard1_Cancel(object sender, RoutedEventArgs e)
        {
            setContext(false);
            this.Wizard1.CurrentPage = this.FirstPage;
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
                         && p.b_isxyei == true
                         select p.poso;

                payment.BuildTitle = (this.BuildCombo.SelectedItem as Building).Title;
                payment.AppTitle = (this.AppCombo.SelectedItem as appartment).apptitle;
                payment.Owner = (this.AppCombo.SelectedItem as appartment).ownerid;
                payment.Resident = (this.AppCombo.SelectedItem as appartment).resedentid;
                payment.Dept = q.Count()==0?0M:q.Sum();
            }

            if (this.Wizard1.CurrentPage == Page2)
            {
                if (string.IsNullOrWhiteSpace(payment.Barcode))
                {
                    e.Cancel = true;
                    return;
                }

                var tameio = (from p in db.Tameios
                             where p.barcode.Equals(payment.Barcode)
                             select p).FirstOrDefault();

                if (tameio == null)
                {
                    e.Cancel = true;
                    return;
                }

                payment.BuildId = payment.BuildId;
                payment.AppId = tameio.APPID.Value;

                var q = from p in db.XreosiPistosis
                        where p.appid == payment.AppId
                        && p.b_isxyei == true
                        select p.poso;

                payment.BuildTitle = tameio.buildTitle;
                payment.AppTitle = string.Format("{0} {1} {2}",tameio.AppTitle,tameio.owner,tameio.resident);
                payment.Dept = q.Count() == 0 ? 0M : q.Sum();
            }

            if (this.Wizard1.CurrentPage == Page5)
            {
                calcReturn();
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
                
        private void calcReturn()
        {
            if (payment.Amount == 0) payment.Amount = payment.Dept;
            payment.Refound = payment.Total -  payment.Amount;
            var change = payment.Refound;
            foreach (var coin in payment.RefoundCoins)
            {
                int count = (int)(change / coin.Amount);
                change -= count * coin.Amount;
                coin.Quantity = count;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var buildingList = from b in db.Buildings
                               where b.Active == true && b.Managment == 1
                               orderby b.Street, b.StreetNumber
                               select b;

            this.BuildCombo.ItemsSource = buildingList.ToList();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db.Dispose();
        } 
    }
}
