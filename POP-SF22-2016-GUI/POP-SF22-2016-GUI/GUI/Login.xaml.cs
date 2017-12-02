using POP_SF22_2016_GUI.model;
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
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = tbUsername.Text;
            string password = pbPassword.Password.ToString();
            int brojac = 0;
            var lista = RadSaPodacima.Instance.Korisnici;
            foreach(Korisnik k in lista)
            {
                if (k.Username.Equals(username) && k.Password.Equals(password))
                {
                    brojac += 1;
                }
               
            }
            if (brojac > 0)
            {
                var prozor = new MainPrikaz();
                this.Hide();
                prozor.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Pogresno uneti podaci!");
                
            }
            this.Show();
        }
    }
}
