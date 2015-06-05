using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>

    public partial class FormaZaposlenik : Window
    {
        List<Button> dugmad;
        public FormaZaposlenik()
        {
            dugmad = new List<Button>();
            InitializeComponent();
            foreach(Button b in grid1.Children)
            {
                dugmad.Add(b);
            }
        }
        
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (Button b in grid1.Children)
            {
                if(b.Visibility!= System.Windows.Visibility.Hidden)
                {

                    if ((b.Content.ToString().Substring(0, b.Content.ToString().Count()-2)) == (sender as Button).Content.ToString())
                    {
                        
                        //b.Content = "Kafa 5";
                        b.Content = (sender as Button).Content.ToString() + " " + Convert.ToChar(Convert.ToInt32(b.Content.ToString()[b.Content.ToString().Count() - 1]) + 1);
                        return;
                    }
                }
            }
            foreach (Button b in grid1.Children)
            {
                if (b.Visibility == System.Windows.Visibility.Hidden)
                {
                    b.Visibility = System.Windows.Visibility.Visible;
                    b.Content = (sender as Button).Content.ToString() + " 1";
                        return;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (Button b in grid1.Children)
                b.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
