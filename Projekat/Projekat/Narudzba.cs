using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Projekat
{
    class Narudzba : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string narudzbaID;
        public string NarudzbaID
        {
            get { return narudzbaID; }
            set { narudzbaID = value; OnPropertyChanged("NarudzbaID"); }
        }

        private DateTime vrijeme = DateTime.Now;

        private string imeKonobara;

        public string ImeKonobara
        {
            get { return imeKonobara; }
            set { imeKonobara = value; OnPropertyChanged("ImeKonobara"); }
        }

        ObservableCollection<BrojnostArtikla> artikli;

        public Narudzba()
        {
            artikli = new ObservableCollection<BrojnostArtikla>();
        }

        public Narudzba(string ime, string id)
        {
            imeKonobara = ime;
            narudzbaID = id;
            artikli = new ObservableCollection<BrojnostArtikla>();
        }

        public ObservableCollection<BrojnostArtikla> Artikli
        {
            get { return artikli; }
            set { artikli = value; OnPropertyChanged("Artkikli"); }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public double dajSveCijenu()
        {
            double suma = 0;
            foreach(BrojnostArtikla b in Artikli)
            {
                suma += b.BrojArtikala *b.Cijena;
            }
            return suma;
        }

    }
}
