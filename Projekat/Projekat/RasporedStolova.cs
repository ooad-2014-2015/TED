using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Projekat
{
    public class RasporedStolova
    {
        public event PropertyChangedEventHandler PropertyChanged;
        List<Stol> stolovi;

        public List<Stol> Stolovi
        {
            get { return stolovi; }
            set { stolovi = value; OnPropertyChanged("Stolovi"); }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
