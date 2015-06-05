using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekat
{
    class VlasnikView:  INotifyPropertyChanged 
    {


        ObservableCollection<BrojnostArtikla> artikli;
        ObservableCollection<Narudzba> narudzbe;

        internal ObservableCollection<Narudzba> Narudzbe
        {
            get { return narudzbe; }
            set { narudzbe = value; }
        }

        private LoginViewModel roditelj;
     
        public LoginViewModel Roditelj
        {
            get { return roditelj; }
            set { roditelj = value; }
        }
        private Zaposlenik korisnik;

        public ICommand Proba { get; set; }
        public ICommand Kafa { get; set; }
        public ICommand Piva { get; set; }
        public ICommand Sok { get; set; }
        public ICommand Kolac { get; set; }
        public ICommand Viski { get; set; }
        public ICommand Nes { get; set; }
        public ICommand Caj { get; set; }
        public ICommand Topla_Cokolada { get; set; }
        public ICommand Kisela { get; set; }
        public ICommand Surutka { get; set; }
        public ICommand Naplati { get; set; }
       
        public VlasnikView()
        {
            artikli = new ObservableCollection<BrojnostArtikla>();
            narudzbe = new ObservableCollection<Narudzba>();
            narudzbe.Add(new Narudzba());
            Proba = new RelayCommand(proba);
            Kafa = new RelayCommand(kafa);
            Piva = new RelayCommand(piva);
            Sok = new RelayCommand(sok);
            Kolac = new RelayCommand(kolac);
            Viski = new RelayCommand(viski);
            Nes = new RelayCommand(nes);
            Caj = new RelayCommand(caj);
            Topla_Cokolada = new RelayCommand(toplaCokolada);
            Kisela = new RelayCommand(kisela);
            Surutka = new RelayCommand(surutka);
            Naplati = new RelayCommand(naplati);
            artikli.Add(new BrojnostArtikla("Kafa", "k1", 1.5));
            artikli.Add(new BrojnostArtikla("Piva", "p2", 3.0));
            artikli.Add(new BrojnostArtikla("Sok", "s1", 3.0));
            artikli.Add(new BrojnostArtikla("Kolac", "k2", 3.5));
            artikli.Add(new BrojnostArtikla("Viski", "v1", 5.0));
            artikli.Add(new BrojnostArtikla("Nes", "n1", 2.0));
            artikli.Add(new BrojnostArtikla("Caj", "c1", 2));
            artikli.Add(new BrojnostArtikla("Topla Cokolada", "tc1", 3.0));
            artikli.Add(new BrojnostArtikla("Kisela", "k3", 1.5));
            artikli.Add(new BrojnostArtikla("Surutka", "s2", 2.0));
        }

        string ukupno="Ukupno 0.00 KM";

        public string Ukupno
        {
            get { return ukupno; }
            set { ukupno = value; OnPropertyChanged("Ukupno"); }
        }


        public VlasnikView(LoginViewModel p)   
        {
            artikli = new ObservableCollection<BrojnostArtikla>();
            narudzbe = new ObservableCollection<Narudzba>();
            narudzbe.Add(new Narudzba());
            System.Windows.MessageBox.Show("radi");
            Proba = new RelayCommand(proba);
            System.Windows.MessageBox.Show("nesto");
            this.roditelj = p;
            // = p.Artikli;
            narudzbe = new ObservableCollection<Narudzba>();
           // korisnik = new Zaposlenik(roditelj.Otvorio as Zaposlenik);
            Kafa = new RelayCommand(kafa);
            Piva = new RelayCommand(piva);
            Sok = new RelayCommand(sok);
            Kolac = new RelayCommand(kolac);
            Viski = new RelayCommand(viski);
            Nes = new RelayCommand(nes);
            Caj = new RelayCommand(caj);
            Topla_Cokolada = new RelayCommand(toplaCokolada);
            Kisela = new RelayCommand(kisela);
            Surutka = new RelayCommand(surutka);
            Naplati = new RelayCommand(naplati);
            artikli.Add(new BrojnostArtikla("Kafa", "k1", 1.5));
            artikli.Add(new BrojnostArtikla("Piva", "p2", 3.0));
            artikli.Add(new BrojnostArtikla("Sok", "s1", 3.0));
            artikli.Add(new BrojnostArtikla("Kolac", "k2", 3.5));
            artikli.Add(new BrojnostArtikla("Viski", "v1", 5.0));
            artikli.Add(new BrojnostArtikla("Nes", "n1", 2.0));
            artikli.Add(new BrojnostArtikla("Caj", "c1", 2));
            artikli.Add(new BrojnostArtikla("Topla Cokolada", "tc1", 3.0));
            artikli.Add(new BrojnostArtikla("Kisela", "k3", 1.5));
            artikli.Add(new BrojnostArtikla("Surutka", "s2", 2.0));
        }


        private void proba(object obj)
        {

        }

        private void naplati(object obj)
        {
            narudzbe.Add(new Narudzba());
            Ukupno = "Ukupno: 0.00 KM";
        }

        private void surutka(object obj)
        {
            
            foreach (BrojnostArtikla b in narudzbe[narudzbe.Count() - 1].Artikli)
            {
                if (b.Ime == "Surutka")
                {
                    b.BrojArtikala++;
                    Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
                    return;
                }
            }
            foreach (BrojnostArtikla a in artikli)
                if (a.Ime == "Surutka")
                    narudzbe[narudzbe.Count() - 1].Artikli.Add(new BrojnostArtikla(a));
            Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
        }

        private void kisela(object obj)
        {
            
            foreach (BrojnostArtikla b in narudzbe[narudzbe.Count() - 1].Artikli)
            {
                if (b.Ime == "Kisela")
                {
                    b.BrojArtikala++;
                    Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
                    return;
                }
            }
            foreach (BrojnostArtikla a in artikli)
                if (a.Ime == "Kisela")
                    narudzbe[narudzbe.Count() - 1].Artikli.Add(new BrojnostArtikla(a));
            Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
        }

        private void toplaCokolada(object obj)
        {
           
            foreach (BrojnostArtikla b in narudzbe[narudzbe.Count() - 1].Artikli)
            {
                if (b.Ime == "Topla cokolada")
                {
                    b.BrojArtikala++;
                    Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
                    return;
                }
            }
            foreach (BrojnostArtikla a in artikli)
                if (a.Ime == "Topla Cokolada")
                    narudzbe[narudzbe.Count() - 1].Artikli.Add(new BrojnostArtikla(a));
            Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
        }

        private void caj(object obj)
        {
            
            foreach (BrojnostArtikla b in narudzbe[narudzbe.Count() - 1].Artikli)
            {
                if (b.Ime == "Caj")
                {
                    b.BrojArtikala++;
                    Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
                    return;
                }
            }
            foreach (BrojnostArtikla a in artikli)
                if (a.Ime == "Caj")
                    narudzbe[narudzbe.Count() - 1].Artikli.Add(new BrojnostArtikla(a));
            Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
        }

        private void nes(object obj)
        {

            foreach (BrojnostArtikla b in narudzbe[narudzbe.Count() - 1].Artikli)
            {
                if (b.Ime == "Nes")
                {
                    b.BrojArtikala++;
                    Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
                    return;
                }
            }
            foreach (BrojnostArtikla a in artikli)
                if (a.Ime == "Nes")
                    narudzbe[narudzbe.Count() - 1].Artikli.Add(new BrojnostArtikla(a));
            Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
        }

        private void viski(object obj)
        {

            foreach (BrojnostArtikla b in narudzbe[narudzbe.Count() - 1].Artikli)
            {
                if (b.Ime == "Viski")
                {
                    b.BrojArtikala++;
                    Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
                    return;
                }
            }
            foreach (BrojnostArtikla a in artikli)
                if (a.Ime == "Viski")
                    narudzbe[narudzbe.Count() - 1].Artikli.Add(new BrojnostArtikla(a));
            Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
        }

        private void kafa(object obj)
        {

            foreach(BrojnostArtikla b in narudzbe[narudzbe.Count()-1].Artikli)
            {
                if(b.Ime=="Kafa")
                {
                    b.BrojArtikala++;
                    Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
                    return;
                }
            }

            foreach (BrojnostArtikla a in artikli)
                if (a.Ime == "Kafa")
                {
                    narudzbe[narudzbe.Count() - 1].Artikli.Add(new BrojnostArtikla(a));
                }
            Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
            
        }

        private void piva(object obj)
        {

            foreach (BrojnostArtikla b in narudzbe[narudzbe.Count() - 1].Artikli)
            {
                if (b.Ime == "Piva")
                {
                    b.BrojArtikala++;
                    Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
                    return;
                }
            }
            foreach (BrojnostArtikla a in artikli)
                if (a.Ime == "Piva")
                    narudzbe[narudzbe.Count() - 1].Artikli.Add(new BrojnostArtikla(a));
            Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
        }

        private void sok(object obj)
        {

            foreach (BrojnostArtikla b in narudzbe[narudzbe.Count() - 1].Artikli)
            {
                if (b.Ime == "Sok")
                {
                    b.BrojArtikala++;
                    Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
                    return;
                }
            }
            foreach (BrojnostArtikla a in artikli)
                if (a.Ime == "Sok")
                    narudzbe[narudzbe.Count() - 1].Artikli.Add(new BrojnostArtikla(a));
            Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
        }


        private void kolac(object obj)
        {

            foreach (BrojnostArtikla b in narudzbe[narudzbe.Count() - 1].Artikli)
            {
                if (b.Ime == "Kolac")
                {
                    b.BrojArtikala++;
                    Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
                    return;
                }
            }
            foreach (BrojnostArtikla a in artikli)
                if (a.Ime == "Kolac")
                    narudzbe[narudzbe.Count() - 1].Artikli.Add(new BrojnostArtikla(a));
            Ukupno = "Ukupno " + narudzbe[narudzbe.Count() - 1].dajSveCijenu().ToString() + " KM";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        } 
    }
}
