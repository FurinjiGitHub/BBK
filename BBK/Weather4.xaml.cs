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
    public partial class Weather4 : PhoneApplicationPage
    {
        public Weather4()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            Random satunnaisempi = new Random();
            int WeatherDice = satunnaisempi.Next(1, 7) + satunnaisempi.Next(1, 7);

            //Alla oleva koodirivi ei ole pätevä arvontaa varten, koska alkuperäisessä pelissä heitetään kahta kuusitahoista noppaa ja summataan tulokset yhteen. Näin ollen todennäköisyydet eivät olisi samat
            //int WeatherDice = new Random().Next(2, 13);

            if (WeatherDice == 2)
            {
                WeatherTitle.Text = "2. Sweltering Heat";
                WeatherBlock.Text = "It's so hot and humid some players collapse from heat exhaustion. Roll a D6 for each player on the pitch at the end of a drive. On a roll of 1 the player collapses and may not be set up for the next Kick-Off.";
            }

            else if (WeatherDice == 3)
            {
                WeatherTitle.Text = "3. Very Sunny";
                WeatherBlock.Text = "A glorious day, but the blinding sunshine causes a -1 modifier on all passing rolls";
            }
            else if (WeatherDice == 11)
            {
                WeatherTitle.Text = "11. Pouring Rain";
                WeatherBlock.Text = "It's raining, making the ball slippery and difficult to hold. A -1 modifier applies to all catch, intercept, or pick-up rolls.";
            }
            else if (WeatherDice == 12)
            {
                WeatherTitle.Text = "12. Blizzard";
                WeatherBlock.Text = "It's cold and snowing! The ice on the pitch means that any player attempting to move an extra square (GFI) will slip and be Knocked Down on a roll of 1-2, while the snow means that only quick or short passes can be attempted.";
            }
            else
            {
                WeatherTitle.Text = "4-10. Nice";
                WeatherBlock.Text = "Perfect Blood Bowl Weather.";
            }

        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

            if (!settings.Contains("userData2"))
            {
                settings.Add("userData2", WeatherTitle.Text + " - " + WeatherBlock.Text);
            }
            else
            {
                settings["userData2"] = WeatherTitle.Text + " - " + WeatherBlock.Text;
            }

            //Tässä kohtaa tyhjennetään userData4 varmuuden vuoksi
            //Tämä siksi, että aikaisempien käyttökertojen tulokset eivät vaikuttaisi tuloksiin vahingossa, 
            //koska kaikissa tapauksissa seuraava sivu ei tallenna userData4:ään uutta sisältöä, 
            //mutta sen sisältö kuitenkin joka tapauksessa tarkastetaan myöhemmissä vaiheissa ja näin estetään se, 
            //että tarkistus käynnistäisi toimenpiteitä jonkun edellisen käyttökerran tiedon takia

            if (IsolatedStorageSettings.ApplicationSettings.Contains("userData4"))
            {
                IsolatedStorageSettings.ApplicationSettings.Remove("userData4");
            }


        }

    }
}