using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Projekat
{
    class NarudzbaViewModel: INotifyPropertyChanged
    {

        private ZaposlenikViewModel2 parent;

        internal ZaposlenikViewModel2 Parent
        {
            get { return parent; }
            set { parent = value; }
        } 
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        } 
    }
}
