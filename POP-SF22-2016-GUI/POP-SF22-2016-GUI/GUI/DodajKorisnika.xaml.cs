﻿using System;
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
        public DodajKorisnika()
        {
            InitializeComponent();
        }

        private void btnNazad_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}