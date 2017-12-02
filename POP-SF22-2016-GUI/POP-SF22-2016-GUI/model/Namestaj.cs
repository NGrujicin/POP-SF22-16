using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF22_2016_GUI.model
{
    public class Namestaj : INotifyPropertyChanged, ICloneable
    {
        private int id;
        private string naziv;
        private double cena;
        private int kolicina;
        private int tip_namestaja;
        private bool naStanju;
        private Akcija akcijskaCena;
        private TipNamestaja tipNamestaja;
        private int akcijskaCenaId;


        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Naziv
        {
            get { return naziv; }
            set
            {
                naziv = value;
                OnPropertyChanged("Naziv");

            }
        }
        public double Cena
        {
            get { return cena; }
            set
            {
                cena = value;
                OnPropertyChanged("Cena");
            }
        }
        public int Kolicina
        {
            get { return kolicina; }
            set
            {
                kolicina = value;
                OnPropertyChanged("Kolicina");
            }
        }

        public int AkcijskaCenaId
        {
            get { return akcijskaCenaId; }
            set
            {
                akcijskaCenaId = value;
                OnPropertyChanged("TipNamestaja");
            }
        }

        public Akcija AkcijskaCena
        {
            get
            {
                if (akcijskaCena == null)
                {
                    akcijskaCena = Akcija.GetById(AkcijskaCenaId);
                }

                return akcijskaCena;
            }
            set
            {
                akcijskaCena = value;
                OnPropertyChanged("TipNamestaja");
            }
        }
        public TipNamestaja TipNamestaja
        {
            get
            {
                if (tipNamestaja == null)
                {
                    tipNamestaja = TipNamestaja.GetById(Tip_Namestaja);
                }
                return tipNamestaja;
            }
            set
            {
                tipNamestaja = value;
                tip_namestaja = tipNamestaja.Id;
                OnPropertyChanged("TipNamestaja");
            }
        }


        public bool NaStanju
        {
            get { return naStanju; }
            set
            {
                naStanju = value;
                OnPropertyChanged("NaStanju");
            }
        }

        public int Tip_Namestaja
        {
            get { return tip_namestaja; }
            set
            {
                tip_namestaja = value;
                OnPropertyChanged("Tip_Namestaja");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return new Namestaj()
            {
                Id = id,
                Naziv = naziv,
                Cena = cena,
                NaStanju = naStanju,
                TipNamestaja = tipNamestaja,
                Kolicina = kolicina,
                Tip_Namestaja = tip_namestaja,
                AkcijskaCenaId = akcijskaCenaId,
                AkcijskaCena = akcijskaCena
            };
        }

        public override string ToString()
        {
            return $"naziv: {Naziv}, cena: {Cena} shekela, kolicina: {Kolicina}, Id: {Id} ";
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
