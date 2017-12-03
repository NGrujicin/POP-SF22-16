using POP_SF22_2016_GUI.model;
using POP_SF22_2016_GUI.Utils;
using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Interaction logic for DodajNamestaj.xaml
    /// </summary>
    public partial class DodajNamestaj : Window
    {
        int operacija = 0;
        private Namestaj izabrani;
        public DodajNamestaj(int broj, Namestaj namestaj)
        {
            InitializeComponent();
            this.izabrani = namestaj;
            operacija = broj;

            cbTip.ItemsSource = RadSaPodacima.Instance.TipoviNamestaja;
            tbNaziv.DataContext = izabrani;
            tbCena.DataContext = izabrani;
            tbKolicina.DataContext = izabrani;
            cbTip.DataContext = izabrani;
            if (operacija == 2)
            {
                foreach (TipNamestaja t in cbTip.Items)
                {
                    if (izabrani.TipNamestaja.ToString().Equals(t.Naziv))
                    {
                        cbTip.SelectedValue = t;
                    }
                }
            }

        }

        private void btnNazad_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            var izabrani_tip_namestaja = (TipNamestaja)cbTip.SelectedItem;
            var lista = RadSaPodacima.Instance.Namestaj;
            var poruka_greska = false;
            var poruka_prazno = false;
            string poruka = " Niste uneli polje: ";
            string greska = "Pogresno ste uneli polje: ";
            int parsedTest;

            if (tbCena.Text == "")
            {
                poruka_prazno = true;
                poruka += " Cena ";
            }
            if (!int.TryParse(tbCena.Text, out parsedTest))
            {
                poruka_greska = true;
                greska += " Cena ";


            }
            if (tbKolicina.Text == "")
            {
                poruka_prazno = true;
                poruka += " Kolicina ";

            }
            if (!int.TryParse(tbKolicina.Text, out parsedTest))
            {
                poruka_greska = true;
                greska += " Kolicina ";

            }
            if (tbNaziv.Text == "")
            {
                poruka_prazno = true;
                poruka += " Naziv ";

            }
            if (cbTip.SelectedItem == null)
            {
                poruka_prazno = true;
                poruka += " Tip ";

            }
            if (poruka_prazno == true || poruka_greska == true)
            {
                MessageBox.Show(poruka, greska);
            }
            else if (poruka_greska == false && poruka_prazno == false)
            {
                if (operacija == 1)
                {
                    izabrani.Id = lista.Count + 1;

                    lista.Add(izabrani);
                    GenericSerialize.Serialize("listaNam.xml", lista);
                    this.Close();

                }
                else if (operacija == 2)
                {
                    foreach (Namestaj n in lista)
                    {
                        if (n.Id == izabrani.Id)
                        {
                            n.Kolicina = izabrani.Kolicina;
                            n.Cena = izabrani.Cena;
                            n.Naziv = izabrani.Naziv;
                            n.TipNamestaja = izabrani.TipNamestaja;
                        }
                    }
                    GenericSerialize.Serialize("listaNam.xml", lista);
                    this.Close();

                }

            }

        }
    }
}
