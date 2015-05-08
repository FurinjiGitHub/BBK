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
    public partial class KickOff3 : PhoneApplicationPage
    {
        public KickOff3()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {

                
        }
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random satunnaisempi = new Random();

            if (Convert.ToBoolean(Skill.IsChecked))
            {
                
                String SkillMuuttuja = satunnaisempi.Next(1, 7).ToString();
                String RuutuApuri = satunnaisempi.Next(1, 9).ToString();
                KickDirection.Text = "Direction: " + RuutuApuri;
             

                if (SkillMuuttuja == "1")
                {
                    KickLenght.Text = "Length: 1 or 0 squares";
                }
                else if (SkillMuuttuja == "2")
                {
                    KickLenght.Text = "Length: 2 or 1 squares";
                }
                else if (SkillMuuttuja == "3")
                {
                    KickLenght.Text = "Length: 3 or 1 squares";
                }
                else if (SkillMuuttuja == "4")
                {
                    KickLenght.Text = "Length: 4 or 2 squares";
                }
                else if (SkillMuuttuja == "5")
                {
                    KickLenght.Text = "Length: 5 or 2 squares";
                }
                else
                {
                    KickLenght.Text = "Length: 6 or 3 squares";
                }

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
                    KickDirection.Text = "Hups";
                }
                
            }
            else
            {
                String RuutuApuri = satunnaisempi.Next(1, 9).ToString();
                KickDirection.Text = "Direction: " + RuutuApuri;
                KickLenght.Text = "Length: " + satunnaisempi.Next(1, 7).ToString() + " squares";

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
                    KickDirection.Text = "Hups";
                }
            }
           

            //Näin ei saatu tarpeeksi satunnaisia "noppatuloksia" kahteen eri heittoon
            //KickDirection.Text = new Random().Next(1, 9).ToString();
            //KickLenght.Text = new Random().Next(1, 7).ToString();
           // KickButton.IsEnabled = false;
            done.IsEnabled = true;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}