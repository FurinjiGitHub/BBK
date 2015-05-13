using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace BBK
{
    public partial class Bounce6 : PhoneApplicationPage
    {
        public Bounce6()
        {
            InitializeComponent();
        }

        private void collapseAll()
        {
            ruutu1.Visibility = System.Windows.Visibility.Collapsed;
            ruutu2.Visibility = System.Windows.Visibility.Collapsed;
            ruutu3.Visibility = System.Windows.Visibility.Collapsed;
            ruutu4.Visibility = System.Windows.Visibility.Collapsed;
            ruutu5.Visibility = System.Windows.Visibility.Collapsed;
            ruutu6.Visibility = System.Windows.Visibility.Collapsed;
            ruutu7.Visibility = System.Windows.Visibility.Collapsed;
            ruutu8.Visibility = System.Windows.Visibility.Collapsed;
        }

        int countteri = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String BounceTesti = string.Empty;
            countteri++;

            if (IsolatedStorageSettings.ApplicationSettings.Contains("userData4"))
            {
                BounceTesti = IsolatedStorageSettings.ApplicationSettings["userData4"] as string;

            }

            if ((BounceTesti == "4") || (BounceTesti == "5") || (BounceTesti == "6") || (BounceTesti == "7") || (BounceTesti == "8") || (BounceTesti == "9") || (BounceTesti == "10"))
            {
                
                Random satunnaisempi = new Random();
                int RuutuApuri = satunnaisempi.Next(1, 9);
                BounceDirection.Text = "Direction: " + RuutuApuri;
                Nice.Text = "and now hit the Bounce again because the changing weather moves the ball one more square.";
                

                if (countteri < 2)
                {

                    switch (RuutuApuri)
                    {
                        case 1: collapseAll();
                            ruutu1.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 2: collapseAll();
                            ruutu2.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 3: collapseAll();
                            ruutu3.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 4: collapseAll();
                            ruutu4.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 5: collapseAll();
                            ruutu5.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 6: collapseAll();
                            ruutu6.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 7: collapseAll();
                            ruutu7.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 8: collapseAll();
                            ruutu8.Visibility = System.Windows.Visibility.Visible;
                            break;
                        default: collapseAll();
                            BounceDirection.Text = "hups";
                            break;                       
                   }              
                }
                else
                {
                    Bounce.IsEnabled = false;
                    done.IsEnabled = true;
                    Nice.Text = "There you go good boy no run along";

                    switch (RuutuApuri)
                    {
                        case 1: collapseAll();
                            ruutu1.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 2: collapseAll();
                            ruutu2.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 3: collapseAll();
                            ruutu3.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 4: collapseAll();
                            ruutu4.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 5: collapseAll();
                            ruutu5.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 6: collapseAll();
                            ruutu6.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 7: collapseAll();
                            ruutu7.Visibility = System.Windows.Visibility.Visible;
                            break;
                        case 8: collapseAll();
                            ruutu8.Visibility = System.Windows.Visibility.Visible;
                            break;
                        default: collapseAll();
                            BounceDirection.Text = "hups";
                            break;
                    }   
                }
            }

            else
            {
                Random satunnaisempi = new Random();
                int RuutuApuri = satunnaisempi.Next(1, 9);
                BounceDirection.Text = "Direction: " + RuutuApuri;
                Bounce.IsEnabled = false;
                done.IsEnabled = true;

                switch (RuutuApuri)
                {
                    case 1: collapseAll();
                        ruutu1.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 2: collapseAll();
                        ruutu2.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 3: collapseAll();
                        ruutu3.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 4: collapseAll();
                        ruutu4.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 5: collapseAll();
                        ruutu5.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 6: collapseAll();
                        ruutu6.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 7: collapseAll();
                        ruutu7.Visibility = System.Windows.Visibility.Visible;
                        break;
                    case 8: collapseAll();
                        ruutu8.Visibility = System.Windows.Visibility.Visible;
                        break;
                    default: collapseAll();
                        BounceDirection.Text = "hups";
                        break;
    
                }
            }        
        }
    }
}