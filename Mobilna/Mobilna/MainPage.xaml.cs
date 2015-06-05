using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Mobilna.Resources;


namespace Mobilna
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public static int Stol { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Stol = (new Random(DateTime.Now.Millisecond)).Next(1, 10);
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TEDtim.xaml", UriKind.Relative));
        }

        private void KonobarButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Konobar.xaml", UriKind.Relative));
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {

                StolText.Text += Stol;
        }

        private void ZalbaButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Zalba.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}