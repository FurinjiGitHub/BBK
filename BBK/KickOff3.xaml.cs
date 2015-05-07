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
                KickDirection.Text = "Direction: " + satunnaisempi.Next(1, 9).ToString();

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
                
            }
            else
            {
                KickDirection.Text = "Direction: " + satunnaisempi.Next(1, 9).ToString();
                KickLenght.Text = "Length: " + satunnaisempi.Next(1, 7).ToString() + " squares";

            }
           

            //Näin ei saatu tarpeeksi satunnaisia "noppatuloksia" kahteen eri heittoon
            //KickDirection.Text = new Random().Next(1, 9).ToString();
            //KickLenght.Text = new Random().Next(1, 7).ToString();

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}