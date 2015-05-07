using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BBK.Resources;

namespace BBK
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Flip_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new Uri("/Instructions2.xaml?CoinSelect=" + CoinText.Text, UriKind.Relative));
        }

    
        private void Tails_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            CoinText.Text = "Tails";
       
            //tailText.Text = "Tails";
            //tailText.Visibility = System.Windows.Visibility.Visible;
            //headsText.Visibility = System.Windows.Visibility.Collapsed;
            
        }

        private void Heads_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            CoinText.Text = "Heads";

            //headsText.Text = "Heads";
            //headsText.Visibility = System.Windows.Visibility.Visible;
            //tailText.Visibility = System.Windows.Visibility.Collapsed;
            
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