﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF22_2016_GUI.model
{
    public class DodatnaUsluga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }
        public bool Obrisan { get; set; }
    }
}
