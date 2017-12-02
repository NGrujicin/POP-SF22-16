using POP_SF22_2016_GUI.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POP_SF22_2016_GUI.GUI
{
    public partial class MainPrikaz : Window
    {

        public Korisnik korisnik_kopija { get; set; }
        public Korisnik korisnik { get; set; }

        public Object Objekat { get; set; }

        public string izbor = "";

        private ICollectionView view;

        public MainPrikaz()
        {
            InitializeComponent();
            dgMainPrikaz.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void btNazad_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btKorisnici_Click(object sender, RoutedEventArgs e)
        {
            izbor = "korisnik";
            Objekat = null;
            Objekat = korisnik;
            dgMainPrikaz.DataContext = this;
            view = CollectionViewSource.GetDefaultView(RadSaPodacima.Instance.Korisnici);
            
            dgMainPrikaz.ItemsSource = view;
            dgMainPrikaz.IsSynchronizedWithCurrentItem = true;
            
            dgMainPrikaz.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);

        }
    }
}
