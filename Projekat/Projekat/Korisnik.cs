using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel; 
using System.Threading.Tasks;

namespace Projekat
{
    public abstract class Korisnik : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; OnPropertyChanged("Ime"); }
        }

        protected string prezime;
            public string Prezime   {
                get{return prezime; }
                set{prezime = value; OnPropertyChanged("Prezime"); }
            }

        protected string username;
            public string Username
            {
                get { return username; }
                set { username = value; OnPropertyChanged("Username"); }
            }

        protected string password;
            public string Password
            {
                 get { return password; }
                 set { password = value; OnPropertyChanged("Password"); }
            }

        protected string jmbg;
        public string JMBG  {
            get {return jmbg;}
            set { jmbg = value; OnPropertyChanged("JMBG"); }
        }

        string brojLicne;
        public string BrojLicne
        {
            get { return brojLicne; }
            set { brojLicne = value; OnPropertyChanged("BrojLicne"); }
        }

        public Korisnik(string name, string surname, string user, string pw, string jbg, string licna)
        {
            ime = name;
            prezime = surname;
            username = user;
            password = pw;
            jmbg = jbg;
            brojLicne = licna; 
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
