using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Projekat
{
    class Sistem
    {
        public event PropertyChangedEventHandler PropertyChanged;
        List<Smjena> smjene;

        public List<Smjena> Smjene
        {
            get { return smjene; }
            set { smjene = value; OnPropertyChanged("Smjene");}
        }



        List<RasporedStolova> raspored;

        public List<RasporedStolova> Raspored
        {
            get { return raspored; }
            set { raspored = value; OnPropertyChanged("Raspored");}
        }



        List<Zalba> knjigaZalbi;

        internal List<Zalba> KnjigaZalbi
        {
            get { return knjigaZalbi; }
            set { knjigaZalbi = value; OnPropertyChanged("KnjigaZalbi");  }
        }


        List<Korisnik> korisnici;

        public List<Korisnik> Korisnici
        {
            get { return korisnici; }
            set { korisnici = value; OnPropertyChanged("Korisnici");  }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
