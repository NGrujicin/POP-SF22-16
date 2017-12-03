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
    /// Interaction logic for DodajAkciju.xaml
    /// </summary>
    public partial class DodajAkciju : Window
    {
        int operacija = 0;
        private Akcija izabrani;
        public DodajAkciju(int broj, Akcija akcija)
        {
            InitializeComponent();
            izabrani = akcija;
            operacija = broj;
            dpPocetak.DataContext = izabrani;
            dpKraj.DataContext = izabrani;
            tbPopust.DataContext = izabrani;
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            var lista = RadSaPodacima.Instance.Akcije;
            var poruka_prazno = false;
            var poruka_greska = false;
            string poruka = "Niste uneli polje";
            string pogresno = "Pocetak akcije ne moze biti veci od kraja";
            int temp;
            if (dpKraj.Text == "")
            {
                poruka_prazno = true;
                poruka += "datum zavrsetka";
            }
            if (dpPocetak.Text == "")
            {
                poruka_prazno = true;
                poruka += "datum pocetka";
            }
            if (!int.TryParse(tbPopust.Text, out temp))
            {
                poruka_prazno = true;
                poruka += "popust";
            }
            if (izabrani.Datum_Pocetka > izabrani.Datum_Zavrsetka)
            {
                poruka_greska = true;

            }
            if (poruka_prazno == true)
            {
                MessageBox.Show(poruka);
            }
            if (poruka_greska == true)
            {
                MessageBox.Show(pogresno);
            }
            if (operacija == 1)
            {
                izabrani.Id = lista.Count + 1;
                lista.Add(izabrani);
                GenericSerialize.Serialize("Akcije.xml", lista);
                this.Close();
            }
            else if (operacija == 2)
            {
                foreach (Akcija a in lista)
                {
                    if (a.Id == izabrani.Id)
                    {
                        a.Datum_Pocetka = izabrani.Datum_Pocetka;
                        a.Datum_Zavrsetka = izabrani.Datum_Zavrsetka;
                        a.Popust = izabrani.Popust;
                        GenericSerialize.Serialize("Akcije.xml", lista);
                        break;
                    }
                }
            }
            this.Close();
        }

        private void btnIzlaz_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
