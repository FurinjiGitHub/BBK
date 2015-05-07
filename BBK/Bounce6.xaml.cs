using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace BBK
{
    public partial class Bounce6 : PhoneApplicationPage
    {
        public Bounce6()
        {
            InitializeComponent();
        }

        private void Rectangle_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // BounceDirection.Text = "Direction: " + new Random().Next(1, 9).ToString();

            Random satunnaisempi = new Random();
            String RuutuApuri = satunnaisempi.Next(1, 9).ToString();
            BounceDirection.Text = "Direction: " + RuutuApuri;
         

            if (RuutuApuri == "1")
            {
                ruutu1.Visibility = System.Windows.Visibility.Visible;
                ruutu2.Visibility = System.Windows.Visibility.Collapsed;
                ruutu3.Visibility = System.Windows.Visibility.Collapsed;
                ruutu4.Visibility = System.Windows.Visibility.Collapsed;
                ruutu5.Visibility = System.Windows.Visibility.Collapsed;
                ruutu6.Visibility = System.Windows.Visibility.Collapsed;
                ruutu7.Visibility = System.Windows.Visibility.Collapsed;
                ruutu8.Visibility = System.Windows.Visibility.Collapsed;

            }
            else if (RuutuApuri == "2")
            {
                ruutu1.Visibility = System.Windows.Visibility.Collapsed;
                ruutu2.Visibility = System.Windows.Visibility.Visible;
                ruutu3.Visibility = System.Windows.Visibility.Collapsed;
                ruutu4.Visibility = System.Windows.Visibility.Collapsed;
                ruutu5.Visibility = System.Windows.Visibility.Collapsed;
                ruutu6.Visibility = System.Windows.Visibility.Collapsed;
                ruutu7.Visibility = System.Windows.Visibility.Collapsed;
                ruutu8.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (RuutuApuri == "3")
            {
                ruutu1.Visibility = System.Windows.Visibility.Collapsed;
                ruutu2.Visibility = System.Windows.Visibility.Collapsed;
                ruutu3.Visibility = System.Windows.Visibility.Visible;
                ruutu4.Visibility = System.Windows.Visibility.Collapsed;
                ruutu5.Visibility = System.Windows.Visibility.Collapsed;
                ruutu6.Visibility = System.Windows.Visibility.Collapsed;
                ruutu7.Visibility = System.Windows.Visibility.Collapsed;
                ruutu8.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (RuutuApuri == "4")
            {
                ruutu1.Visibility = System.Windows.Visibility.Collapsed;
                ruutu2.Visibility = System.Windows.Visibility.Collapsed;
                ruutu3.Visibility = System.Windows.Visibility.Collapsed;
                ruutu4.Visibility = System.Windows.Visibility.Visible;
                ruutu5.Visibility = System.Windows.Visibility.Collapsed;
                ruutu6.Visibility = System.Windows.Visibility.Collapsed;
                ruutu7.Visibility = System.Windows.Visibility.Collapsed;
                ruutu8.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (RuutuApuri == "5")
            {
                ruutu1.Visibility = System.Windows.Visibility.Collapsed;
                ruutu2.Visibility = System.Windows.Visibility.Collapsed;
                ruutu3.Visibility = System.Windows.Visibility.Collapsed;
                ruutu4.Visibility = System.Windows.Visibility.Collapsed;
                ruutu5.Visibility = System.Windows.Visibility.Visible;
                ruutu6.Visibility = System.Windows.Visibility.Collapsed;
                ruutu7.Visibility = System.Windows.Visibility.Collapsed;
                ruutu8.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (RuutuApuri == "6")
            {
                ruutu1.Visibility = System.Windows.Visibility.Collapsed;
                ruutu2.Visibility = System.Windows.Visibility.Collapsed;
                ruutu3.Visibility = System.Windows.Visibility.Collapsed;
                ruutu4.Visibility = System.Windows.Visibility.Collapsed;
                ruutu5.Visibility = System.Windows.Visibility.Collapsed;
                ruutu6.Visibility = System.Windows.Visibility.Visible;
                ruutu7.Visibility = System.Windows.Visibility.Collapsed;
                ruutu8.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (RuutuApuri == "7")
            {
                ruutu1.Visibility = System.Windows.Visibility.Collapsed;
                ruutu2.Visibility = System.Windows.Visibility.Collapsed;
                ruutu3.Visibility = System.Windows.Visibility.Collapsed;
                ruutu4.Visibility = System.Windows.Visibility.Collapsed;
                ruutu5.Visibility = System.Windows.Visibility.Collapsed;
                ruutu6.Visibility = System.Windows.Visibility.Collapsed;
                ruutu7.Visibility = System.Windows.Visibility.Visible;
                ruutu8.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (RuutuApuri == "8")
            {
                ruutu1.Visibility = System.Windows.Visibility.Collapsed;
                ruutu2.Visibility = System.Windows.Visibility.Collapsed;
                ruutu3.Visibility = System.Windows.Visibility.Collapsed;
                ruutu4.Visibility = System.Windows.Visibility.Collapsed;
                ruutu5.Visibility = System.Windows.Visibility.Collapsed;
                ruutu6.Visibility = System.Windows.Visibility.Collapsed;
                ruutu7.Visibility = System.Windows.Visibility.Collapsed;
                ruutu8.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                BounceDirection.Text = "Hups";
            }

        }
    }
}