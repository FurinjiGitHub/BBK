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
            //base.OnNavigatedTo(e);
           //string CoinSelect = NavigationContext.QueryString["CoinSelect"];
            //bool Head_Checked = NavigationContext. ["Head_Checked"];
           // bool Head_Checked;

            string CoinSelect = "";
            int Coin = new Random().Next(1, 3);
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
                CoinResult.Text = "Hups";
            }
          /*
            if (Coin == 1)
            {
                CoinResult.Text = "Heads";
            }
            else
            {
                CoinResult.Text = "Tails";
            }
               */
        }
    }
}