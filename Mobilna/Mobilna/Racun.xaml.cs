using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Mobilna
{
    public partial class Racun : PhoneApplicationPage
    {
        List<Artikli> artikli;
        public Racun()
        {
            InitializeComponent();
            mobilnaBazaContext db = new mobilnaBazaContext("mobilnaBaza.sdf");
            artikli = new List<Artikli>();
            var query = from Artikli in db.Artikli
                        join Racuni in db.Racuni on Artikli.Id equals Racuni.ArtikalID
                        where !Racuni.Placeno
                        select Artikli;


            artikli = query.ToList();
            Stol.Text += MainPage.Stol.ToString();
            Racun.ItemsSource = artikli;
            decimal suma = 0;
            foreach (Artikli artikal in artikli)
                suma += artikal.Cijena;
            Ukupno.Text += suma.ToString();
        }
    }
}