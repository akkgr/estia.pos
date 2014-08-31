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

namespace estia.pos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EstiaModel db;
        public MainWindow()
        {
            InitializeComponent();

            db = new EstiaModel();

            var buildingList = from b in db.Buildings
                               where b.Active == true
                               orderby b.Street, b.StreetNumber
                               select b;
            
            this.BuildCombo.ItemsSource = buildingList.ToList();
            
        }

        private void findAccount(object sender, RoutedEventArgs e)
        {
            this.TotalDept.Content = "Σύνολο: 1.500 ευρώ";
        }
    }
}
