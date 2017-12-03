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
    /// Interaction logic for DodajKorisnika.xaml
    /// </summary>
    public partial class DodajKorisnika : Window
    {
        int operacija = 0;
        private Korisnik izabrani;
        public DodajKorisnika(int broj, Korisnik korisnik)
        {
            InitializeComponent();
            TipoviKorisnika();
            izabrani = korisnik;
            operacija = broj;
            tbIme.DataContext = izabrani;
            tbPrezime.DataContext = izabrani;
            tbUsername.DataContext = izabrani;
            if (operacija == 2)
            {
                tbUsername.IsReadOnly = true;
            }
            tbPassword.DataContext = izabrani;
            cbTip.DataContext = izabrani;
        }

        private void TipoviKorisnika()
        {
            cbTip.Items.Add("korisnik");
            cbTip.Items.Add("admin");
        }
        private void btnNazad_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            var izabrani_tip_korisnika = "" + cbTip.SelectedItem;
            var lista = RadSaPodacima.Instance.Korisnici;
            var prazna_poruka = false;
            var greska_poruka = false;
            string poruka = "Niste uneli polje: ";
            string greska = "Usernem zauzet: ";

            if(tbIme.Text == "")
            {
                prazna_poruka = true;
                poruka += "Ime";
            }

            if (tbPrezime.Text == "")
            {
                prazna_poruka = true;
                poruka += "Prezime";
            }

            if (tbUsername.Text == "")
            {
                prazna_poruka = true;
                poruka += "Username";
            }
            if (operacija == 1)
            {
                foreach(Korisnik k in lista)
                {
                    if(k.Username.Equals(tbUsername.Text))
                    {
                        greska_poruka = true;
                    }
                }
            }

            if (tbPassword.Text == "")
            {
                prazna_poruka = true;
                poruka += "Password";
            }

            if (cbTip.SelectedItem == null)
            {
                prazna_poruka = true;
                poruka += "Tip";
            }

            if (prazna_poruka == true || greska_poruka == true)
            {
                MessageBox.Show(poruka, greska);
            }

            else if (prazna_poruka == false || greska_poruka == false)
            {
                if(operacija == 1)
                {
                    lista.Add(izabrani);
                    GenericSerialize.Serialize("Korisnici.xml", lista);
                    this.Close();
                }

                else if (operacija == 2)
                {
                    foreach (Korisnik n in lista)
                    {
                        if(n.Username.Equals(izabrani.Username))
                        {
                            n.Ime = izabrani.Ime;
                            n.Prezime = izabrani.Prezime;
                            n.Username = izabrani.Username;
                            n.Password = izabrani.Password;
                            n.Tip_Korisnika = izabrani.Tip_Korisnika;
                        }
                    }

                    GenericSerialize.Serialize("Korisnici.xml", lista);
                    this.Close();
                }
            }
        }
    }
}
