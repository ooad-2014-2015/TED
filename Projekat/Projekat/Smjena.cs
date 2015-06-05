using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Projekat
{
    public class Smjena
    {
        Korisnik radnik;
        public Korisnik Radnik
        {
            get { return radnik; }
            set { radnik = value; }
        }

        DateTime pocetakSmjene;
        public DateTime PocetakSmjene
        {
            get { return pocetakSmjene; }
            set { pocetakSmjene = value; }
        }

        DateTime krajSmjene;
        public DateTime KrajSmjene
        {
            get { return krajSmjene; }
            set { krajSmjene = value; }
        }

        decimal pazar;
        public decimal Pazar
        {
            get { return pazar; }
            set { pazar = value; }
        }

        public Smjena(DateTime pocetak, DateTime kraj)
        {
            pocetakSmjene = pocetak;
            krajSmjene = kraj;
            pazar = 0; 
        }

    }
}
