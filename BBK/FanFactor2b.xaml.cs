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
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Fans_Click(object sender, RoutedEventArgs e)
        {
            Random satunnaisempi = new Random();
          

            int UserFactor = Convert.ToInt16(UserFanFactor.Text);
            int OpponentFactor = Convert.ToInt16(OpponentFanFactor.Text);

            int Nopat1 = satunnaisempi.Next(1, 7) + satunnaisempi.Next(1, 7) + UserFactor;
            int Nopat2 = satunnaisempi.Next(1, 7) + satunnaisempi.Next(1, 7) + OpponentFactor;

            String FanDice1 = Nopat1.ToString();
            String FanDice2 = Nopat2.ToString();

            FanSupport.Text = "Your team has " + FanDice1 + ".000 fans at the game and Opponents team has " + FanDice2 + ".000 fans";

            if (Nopat1 > Nopat2)
            {
                if (Nopat1 > Nopat2 * 2)
                {
                    FameBlock.Text = "You have FAME +2";
                }
                else
                {
                    FameBlock.Text = "You have FAME +1";
                }
                
            }
            else if (Nopat1 < Nopat2)
            {
                if (Nopat1 * 2 < Nopat2)
                {
                    FameBlock.Text = "Your Opponent has FAME +2";
                }
                else
                {
                    FameBlock.Text = "Your Opponent has FAME +1";
                }
      
            }
            else if (Nopat1 == Nopat2)
            {
                FameBlock.Text = "Equal number of fans: You both have FAME +0";
            }

            else
            {
                FameBlock.Text = "Hups";
            }
        
            Done.IsEnabled = true;
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
         
            if (!settings.Contains("userData"))
            {
                settings.Add("userData", FameBlock.Text);
            }
            else
            {
                settings["userData"] = FameBlock.Text;
            }
            settings.Save();

        }
    }
}