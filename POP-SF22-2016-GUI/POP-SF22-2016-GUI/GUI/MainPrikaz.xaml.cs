using POP_SF22_2016_GUI.model;
using POP_SF22_2016_GUI.Utils;
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

        public Namestaj namestaj_kopija { get; set; }

        public Namestaj namestaj { get; set; }

        public TipNamestaja tipNamestaja_kopija { get; set; }

        public TipNamestaja tipNamestaja { get; set; }

        public Akcija akcija_kopija { get; set; }

        public Akcija akcija { get; set; }

        public Object Objekat { get; set; }

        public string izbor = "";

        private ICollectionView view;

        public MainPrikaz()
        {
            InitializeComponent();
            dgMainPrikaz.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnKorisnici_Click(object sender, RoutedEventArgs e)
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

        private void btnNamestaji_Click(object sender, RoutedEventArgs e)
        {
            izbor = "namestaj";
            Objekat = null;
            Objekat = namestaj;
            dgMainPrikaz.DataContext = this;
            view = CollectionViewSource.GetDefaultView(RadSaPodacima.Instance.Namestaj);

            dgMainPrikaz.ItemsSource = view;
            dgMainPrikaz.IsSynchronizedWithCurrentItem = true;

            dgMainPrikaz.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void btnTipoviNamestaja_Click(object sender, RoutedEventArgs e)
        {
            izbor = "tipNamestaja";
            Objekat = null;
            Objekat = tipNamestaja;
            dgMainPrikaz.DataContext = this;
            view = CollectionViewSource.GetDefaultView(RadSaPodacima.Instance.TipoviNamestaja);

            dgMainPrikaz.ItemsSource = view;
            dgMainPrikaz.IsSynchronizedWithCurrentItem = true;

            dgMainPrikaz.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void btnAkcije_Click(object sender, RoutedEventArgs e)
        {
            izbor = "akcija";
            Objekat = null;
            Objekat = akcija;
            dgMainPrikaz.DataContext = this;
            view = CollectionViewSource.GetDefaultView(RadSaPodacima.Instance.Akcije);

            dgMainPrikaz.ItemsSource = view;
            dgMainPrikaz.IsSynchronizedWithCurrentItem = true;

            dgMainPrikaz.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            if (izbor.Equals(""))
            {
                MessageBox.Show("Niste izabrali pregled ni jednog tipa!");
            }
            else
            {
                if (izbor.Equals("korisnik"))
                {
                    var zaDodati = new Korisnik
                    {
                        Ime = ""
                    };
                    var window = new DodajKorisnika(1, zaDodati);
                    window.ShowDialog();
                }
                else if (izbor.Equals("namestaj"))
                {
                    var zaDodati = new Namestaj()
                    {
                        Naziv = ""

                    };
                    var window = new DodajNamestaj(1, zaDodati);
                    window.ShowDialog();
                }
                else if (izbor.Equals("tipNamestaja"))
                {
                    var zaDodati = new TipNamestaja()
                    {
                        Naziv = ""
                    };
                    var window = new DodajTipNamestaja(1, zaDodati);
                    window.ShowDialog();
                }
                else if (izbor.Equals("akcija"))
                {
                    var zaDodati = new Akcija()
                    {
                        Popust = 0,
                        Datum_Pocetka = DateTime.Now,
                        Datum_Zavrsetka = DateTime.Now,
                    };
                    var window = new DodajAkciju(1, zaDodati);
                    window.ShowDialog();
                }

            }
            view.Refresh();
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            if (izbor.Equals(""))
            {
                MessageBox.Show("Niste izabrali pregled ni jednog tipa!");
            }
            if (izbor.Equals("korisnik"))
            {
                if (dgMainPrikaz.SelectedItem != null)
                {
                    korisnik_kopija = (Korisnik)Objekat;
                    var zaIzmenu = (Korisnik)korisnik_kopija.Clone();
                    var window = new DodajKorisnika(2, zaIzmenu);
                    window.ShowDialog();

                }
                else
                {
                    MessageBox.Show(" Morate izabrati korisnika za izmenu!! ");
                }
            }
            else if (izbor.Equals("namestaj"))
            {
                if (dgMainPrikaz.SelectedItem != null)
                {
                    namestaj_kopija = (Namestaj)Objekat;
                    var prosledjenNamestaj = (Namestaj)namestaj_kopija.Clone();
                    var window = new DodajNamestaj(2, prosledjenNamestaj);
                    window.ShowDialog();

                }
                else
                {
                    MessageBox.Show(" Morate izabrati objekat za izmenu!! ");
                }
            }
            else if (izbor.Equals("tipNamestaja"))
            {
                if (dgMainPrikaz.SelectedItem != null)
                {
                    tipNamestaja_kopija = (TipNamestaja)Objekat;
                    var prosledjenTip = (TipNamestaja)tipNamestaja_kopija.Clone();
                    var window = new DodajTipNamestaja(2, prosledjenTip);
                    window.ShowDialog();

                }
                else
                {
                    MessageBox.Show(" Morate izabrati objekat za izmenu!! ");
                }
            }
            else if (izbor.Equals("akcija"))
            {
                if (dgMainPrikaz.SelectedItem != null)
                {
                    akcija_kopija = (Akcija)Objekat;
                    var prosledjenaAkcija = (Akcija)akcija_kopija.Clone();
                    var window = new DodajAkciju(2, prosledjenaAkcija);
                    window.ShowDialog();

                }
                else
                {
                    MessageBox.Show(" Morate izabrati objekat za izmenu!! ");
                }
            }
            view.Refresh();
        }

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {

            if (izbor.Equals(""))
            {
                MessageBox.Show("Niste izabrali pregled ni jednog tipa!");
            }
            else
            {
                if (izbor.Equals("korisnik"))
                {
                    var lista_korisnika = RadSaPodacima.Instance.Korisnici;
                    var korisnik_kopija = (Korisnik)Objekat;
                    var ob = (Korisnik)korisnik_kopija.Clone();
                    if (ob == null)
                    {
                        MessageBox.Show(" Morate izabrati korisnika za brisanje!! ");
                    }
                    if (ob != null)
                    {
                        foreach (Korisnik n in lista_korisnika)
                        {
                            if (n.Username == ob.Username)
                            {
                                if (n.Obrisan == false)
                                {
                                    n.Obrisan = true;
                                    GenericSerialize.Serialize("Korisnici.xml", lista_korisnika);

                                    break;
                                }
                                else if (n.Obrisan == true)
                                {
                                    n.Obrisan = false;
                                    GenericSerialize.Serialize("Korisnici.xml", lista_korisnika);

                                    break;
                                }
                            }
                        }




                    }
                }
                else if (izbor.Equals("namestaj"))
                {
                    var lista_namestaja = RadSaPodacima.Instance.Namestaj;
                    namestaj_kopija = (Namestaj)Objekat;
                    var ob = (Namestaj)namestaj_kopija.Clone();

                    if (ob == null)
                    {
                        MessageBox.Show(" Morate izabrati objekat za brisanje!! ");
                    }
                    else if (ob != null)
                    {
                        foreach (Namestaj n in lista_namestaja)
                        {
                            if (n.Id == ob.Id)
                            {
                                if (n.NaStanju == false)
                                {
                                    n.NaStanju = true;
                                    GenericSerialize.Serialize("listaNam.xml", lista_namestaja);

                                    break;
                                }
                                else if (n.NaStanju == true)
                                {
                                    n.NaStanju = false;
                                    GenericSerialize.Serialize("listaNam.xml", lista_namestaja);
                                    view.Refresh();
                                    break;
                                }
                            }
                        }




                    }
                }
                else if (izbor.Equals("akcija"))
                {
                    var lista_akcija = RadSaPodacima.Instance.Akcije;
                    var ob = (Akcija)Objekat;
                    if (ob == null)
                    {
                        MessageBox.Show(" Morate izabrati objekat za brisanje!! ");
                    }
                    else if (ob != null)
                    {
                        foreach (Akcija n in lista_akcija)
                        {
                            if (n.Id == ob.Id)
                            {
                                if (n.Datum_Zavrsetka < System.DateTime.Now)
                                {
                                    lista_akcija.Remove(n);
                                    GenericSerialize.Serialize("Akcije.xml", lista_akcija);

                                    break;
                                }

                            }
                        }




                    }
                }
                else if (izbor.Equals("tipNamestaja"))
                {
                    var lista_tipova = RadSaPodacima.Instance.TipoviNamestaja;
                    tipNamestaja_kopija = (TipNamestaja)Objekat;
                    var ob = (TipNamestaja)tipNamestaja_kopija.Clone() ;
                    if (ob == null)
                    {
                        MessageBox.Show(" Morate izabrati objekat za brisanje!! ");
                    }
                    else if (ob != null)
                    {
                        foreach (TipNamestaja n in lista_tipova)
                        {
                            if (n.Id == ob.Id)
                            {
                                if (n.Obrisan == false)
                                {
                                    n.Obrisan = true;
                                    GenericSerialize.Serialize("tipovi_namestaja.xml", lista_tipova);

                                    break;
                                }
                                else if (n.Obrisan == true)
                                {
                                    n.Obrisan = false;
                                    GenericSerialize.Serialize("tipovi_namestaja.xml", lista_tipova);

                                    break;
                                }

                            }
                        }




                    }
                }

            }
            view.Refresh();
        }

       
    }
}
