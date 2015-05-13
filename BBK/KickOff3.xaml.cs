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
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random satunnaisempi = new Random();

            if (Convert.ToBoolean(Skill.IsChecked))
            {
                //Näin ei saatu tarpeeksi satunnaisia "noppatuloksia" kahteen eri heittoon
                //KickDirection.Text = new Random().Next(1, 9).ToString();
                //KickLenght.Text = new Random().Next(1, 7).ToString();
                
                String SkillMuuttuja = satunnaisempi.Next(1, 7).ToString();
                int RuutuApuri = satunnaisempi.Next(1, 9);
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
                        KickDirection.Text = "hups";
                        break;
                }
            }
            else
            {
                int RuutuApuri = satunnaisempi.Next(1, 9);
                KickDirection.Text = "Direction: " + RuutuApuri;
                KickLenght.Text = "Length: " + satunnaisempi.Next(1, 7).ToString() + " squares";

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
                        KickDirection.Text = "hups";
                        break;
                }
                
            }
           
           //Kick-nappulan sammutus kommentoitu, jotta testaaminen mukavampaa
           // KickButton.IsEnabled = false;
            done.IsEnabled = true;
        }
    }
}