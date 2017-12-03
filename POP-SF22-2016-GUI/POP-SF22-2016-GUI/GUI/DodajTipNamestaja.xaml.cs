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
    /// Interaction logic for DodajTipNamestaja.xaml
    /// </summary>
    public partial class DodajTipNamestaja : Window
    {
        int operacija = 0;
        private TipNamestaja izabrani;
        public DodajTipNamestaja(int broj, TipNamestaja objekat)
        {
            InitializeComponent();
            izabrani = objekat;
            operacija = broj;
            tbNaziv.DataContext = izabrani;
        }

        private void btnNazad_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            var lista = RadSaPodacima.Instance.TipoviNamestaja;
            var prazna_poruka = false;
            string poruka = "Niste uneli polje: ";

            if (tbNaziv.Text == "")
            {
                prazna_poruka = true;
                poruka += "Naziv";
            }

            if (prazna_poruka == true)
            {
                MessageBox.Show(poruka);
            }

            else if (prazna_poruka == false)
            {
                if (operacija == 1)
                {
                    izabrani.Id = lista.Count + 1;
                    lista.Add(izabrani);
                    GenericSerialize.Serialize("tipovi_namestaja.xml", lista);
                    this.Close();
                }

                else if (operacija == 2)
                {
                    foreach (TipNamestaja n in lista)
                    {
                        if(n.Id == izabrani.Id)
                        {
                            n.Naziv = izabrani.Naziv;
                        }
                    }
                    GenericSerialize.Serialize("tipovi_namestaja.xml", lista);
                    this.Close();
                }
            }
        }
    }
}
