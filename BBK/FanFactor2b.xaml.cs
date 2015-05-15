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
            long testeri = 0;
            long testeri2 = 0;

            bool testaaja = long.TryParse(UserFanFactor.Text, out testeri);
            bool testaaja2 = long.TryParse(OpponentFanFactor.Text, out testeri2);

            if (testaaja == false && testaaja2 == false)
            {
                FanSupport.Text = "Neither of those Fan Factors make any sense";
                FameBlock.Text = "Try again, joker!";
            }

            else if (testaaja == false)
            {
                FanSupport.Text = "Don't mess with me your Fan Factor can't look like that!";
                FameBlock.Text = "Try again, bub...";
            }

            else if (testaaja2 == false)
            {
                FanSupport.Text = "I'm sure your Opponents Fan Factor doesn't look like that!";
                FameBlock.Text = "Try again, sneaky git...";
            }

            else if (testaaja == true && testaaja2 == true)
            {
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
                    FameBlock.Text = "Ooops, Goblins broke something!";
                }
                
                Done.IsEnabled = true;
                //Fanien laskentanappulan sammutus kommentoitu, jotta testaaminen miellekkäämpää
                //Fans.IsEnabled = false;

            }
            else
            {
                FanSupport.Text = "Ooops, Goblins broke something! Get back while you can!";
                FameBlock.Text = "";
            }           
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

        private void UserFanFactor_LostFocus(object sender, RoutedEventArgs e)
        {
            String nollaaja = UserFanFactor.Text;
            if (nollaaja == "")
            {
                UserFanFactor.Text = "0";
            }
        }

        private void OpponentFanFactor_LostFocus(object sender, RoutedEventArgs e)
        {
            String nollaaja = OpponentFanFactor.Text;
            if (nollaaja == "")
            {
                OpponentFanFactor.Text = "0";
            }
        }

    }
}