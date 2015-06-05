using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Projekat
{
    public class Zaposlenik: Korisnik, INotifyPropertyChanged
    {
        private decimal dnevnica;
        public decimal Dnevnica
        {
            get { return dnevnica; }
            set { dnevnica = value; OnPropertyChanged("Dnevnica"); }
        }
        public Zaposlenik(string name, string surname, string user, string pw, string jbg, string licna, decimal dnevno)
            : base(name, surname, user, pw, jbg, licna)
        {
            dnevnica = dnevno; 
        }
        public Zaposlenik(Zaposlenik z)
            : base(z.ime, z.prezime, z.username, z.password, z.jmbg, z.BrojLicne)
        {
            dnevnica = z.dnevnica;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs( propertyName));
        }
    }
}
