using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Projekat
{
    public class Vlasnik: Korisnik, INotifyPropertyChanged
    {
        private decimal mjesecnaDobit;
            public decimal MjesecnaDobit
            {
               get { return mjesecnaDobit; }
               set { mjesecnaDobit = value; OnPropertyChanged("MjesecnaDobit"); }
            }

            /*public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }*/


            public Vlasnik(string name, string surname, string user, string pw, string jbg, string licna, decimal dobit)
                : base(name, surname, user, pw, jbg, licna)
            {
                mjesecnaDobit = dobit; 
            }
    }
}
