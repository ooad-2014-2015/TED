using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    public class BrojnostArtikla : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        int brojArtikala;

        public int BrojArtikala
        {
            get { return brojArtikala; }
            set { brojArtikala = value; }
        }

        private string artikalID;
        public string ArtikalID
        {
            get { return artikalID; }
            set { artikalID = value; OnPropertyChanged("ArtikalID"); }

        }

        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; OnPropertyChanged("Ime"); }
        }
        private double cijena;
        public double Cijena
        {
            get { return cijena; }
            set { cijena = value; OnPropertyChanged("Cijena"); }
        }

        public BrojnostArtikla(string naziv, string id, double c ,int broj = 1)
        {   
            brojArtikala = broj;
            artikalID=id;
            ime=naziv;
            cijena = c;
        }
        public BrojnostArtikla(BrojnostArtikla b)
        {
            brojArtikala = b.brojArtikala;
            artikalID = b.artikalID;
            ime = b.ime;
            cijena = b.cijena;
        }
    }
}
