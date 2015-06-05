using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekat
{
    class LoginViewModel: INotifyPropertyChanged 
    {
        ObservableCollection<Artikal> artikli;

        public ObservableCollection<Artikal> Artikli
        {
            get { return artikli; }
            set { artikli = value; }
        }
        private VlasnikViewModel dijeteVlasnikViewModel;

        public VlasnikViewModel DijeteVlasnikViewModel
        {
            get { return dijeteVlasnikViewModel; }
            set { dijeteVlasnikViewModel = value; }
        }
        private ZaposlenikViewModel2 dijeteZaposlenikViewModel;

        public ZaposlenikViewModel2 DijeteZaposlenikViewModel
        {
            get { return dijeteZaposlenikViewModel; }
            set { dijeteZaposlenikViewModel = value; }
        }

        private ObservableCollection<Korisnik> korisnici;
        private  Korisnik otvorio;

        public  Korisnik Otvorio
        {
            get { return otvorio; }
            set { otvorio = value; }
        }
       /* Sistem sistem;

        internal Sistem Sistem
        {
            get { return sistem; }
            set { sistem = value;  }
        } */

        public ICommand Potvrdi { get; set; }
        string username = "Username";

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        string password = "Password";

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public LoginViewModel()
        {
            artikli = new ObservableCollection<Artikal>();
            
            artikli.Add(new Artikal("Kafa", "k1", Convert.ToDecimal(1.5)));
            artikli.Add(new Artikal("Piva", "p2", Convert.ToDecimal(3.0)));
            artikli.Add(new Artikal("Sok", "s1", Convert.ToDecimal(3.0)));
            artikli.Add(new Artikal("Kolac", "k2", Convert.ToDecimal(3.5)));
            artikli.Add(new Artikal("Viski", "v1", Convert.ToDecimal(5.0)));
            artikli.Add(new Artikal("Nes", "n1", Convert.ToDecimal(2.0)));
            artikli.Add(new Artikal("Caj", "c1", Convert.ToDecimal(2)));
            artikli.Add(new Artikal("Topla Cokolada", "tc1", Convert.ToDecimal(3.0)));
            artikli.Add(new Artikal("Kisela", "k3", Convert.ToDecimal(1.5)));
            artikli.Add(new Artikal("Surutka","s2",Convert.ToDecimal(2.0)));


            korisnici = new ObservableCollection<Korisnik>();
            //System.Windows.MessageBox.Show("test");
            korisnici.Add(new Vlasnik("kemo", "kemic", "kemo", "123", "12345678902134", "VRLO", 98789));
            korisnici.Add(new Zaposlenik("dizda", "dizna", "dizda", "dizna", "09876543210987", "MALO", 0));
            
            //dijeteVlasnikViewModel = new VlasnikViewModel(this); 
           
            dijeteZaposlenikViewModel = new ZaposlenikViewModel2(this); 
            Potvrdi = new RelayCommand(potvrdi);
        }
        string nekiTekst = "picka";

        public string NekiTekst
        {
            get { return nekiTekst; }
            set { nekiTekst = value; OnPropertyChanged("NekiTekst"); }
        }
        public void potvrdi(object parameter)
        {
            NekiTekst = "kurac";
           // Button b = parameter as Button;
            //string s = b.Name;
            foreach  (Korisnik korisnik in korisnici)
            {
                if (username == korisnik.Username && password==korisnik.Password)
                {
                    if(korisnik is Vlasnik)
                    {
                        FormaVlasnik nova = new FormaVlasnik();
                        Otvorio = korisnik as Vlasnik;
                        dijeteVlasnikViewModel = new VlasnikViewModel(this);
                        nova.Show();
                        break;
                    }
                    else
                    {
                        FormaZaposlenik nova = new FormaZaposlenik();
                        Otvorio = korisnik as Zaposlenik;
                        dijeteZaposlenikViewModel = new ZaposlenikViewModel2(this);
                        nova.Show();
                        break;
                        
                    }
                    System.Windows.MessageBox.Show("Pogresan password");

                }
                
                
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)   {
            if(PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        } 
    }
}
