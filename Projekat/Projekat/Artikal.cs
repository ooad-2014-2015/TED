using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Projekat
{
    public class Artikal : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
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
        private decimal cijena;
        public decimal Cijena
        {
            get { return cijena; }
            set { cijena = value; OnPropertyChanged("Cijena"); }
        }
        public Artikal(string naziv, string id, decimal c)
        {
            ime = naziv;
            artikalID = id;
            cijena = c;
        }
        public Artikal(Artikal art)
        {
            ime = art.Ime;
            artikalID = art.ArtikalID;
            cijena = art.Cijena;
        }

    }
}
