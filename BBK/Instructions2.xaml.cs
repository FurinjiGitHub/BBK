using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace BBK
{
    public partial class Instructions2 : PhoneApplicationPage
    {
        public Instructions2()
        {
            InitializeComponent();         
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            string CoinSelect = "";

            //Tehdään varsinainen kolikonheitto eli arvotaan ykkönen tai kakkonen
            int Coin = new Random().Next(1, 3);

            //Vastaanotetaan edellisen sivun "lähettämä" valintateksti
            if (NavigationContext.QueryString.TryGetValue("CoinSelect", out CoinSelect))
            
            if (CoinSelect == "Heads")
            {
                if (Coin == 1)
                {
                    BitmapImage kolikko = new BitmapImage(new Uri(@"Assets/Heads.png", UriKind.RelativeOrAbsolute));
                    CoinResultImage.Source = kolikko;
                    CoinResult.Text = "Heads! You Win";
                }
                else
                {
                    BitmapImage kolikko = new BitmapImage(new Uri(@"Assets/Tails.png", UriKind.RelativeOrAbsolute));
                    CoinResultImage.Source = kolikko;
                    CoinResult.Text = "Tails! You Lose";
                }
            }

            else if (CoinSelect == "Tails")
            {
                if (Coin == 1)
                {
                    BitmapImage kolikko = new BitmapImage(new Uri(@"Assets/Heads.png", UriKind.RelativeOrAbsolute));
                    CoinResultImage.Source = kolikko;
                    CoinResult.Text = "Heads! You Lose";
                }
                else
                {
                    BitmapImage kolikko = new BitmapImage(new Uri(@"Assets/Tails.png", UriKind.RelativeOrAbsolute));
                    CoinResultImage.Source = kolikko;
                    CoinResult.Text = "Tails! You Win";
                }
            }

            else
            {
                CoinResult.Text = "Ooops, Goblins broke something! Get back while you can!";
            }

        }
    }
}