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
    public partial class Weather4 : PhoneApplicationPage
    {
        public Weather4()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {

            int WeatherDice = new Random().Next(2, 13);

            if (WeatherDice == 2)
            {
                WeatherBlock.Text = "2. Sweltering Heat: It's so hot and humid some players collapse from heat exhaustion. Roll a D6 for each player on the pitch at the end of a drive. On a roll of 1 the player collapses and may not be set up for the next Kick-Off.";
            }

            else if (WeatherDice == 3)
            {
                WeatherBlock.Text = "3. Very Sunny: A glorious day, but the blinding sunshine causes a -1 modifier on all passing rolls";
            }
            else if (WeatherDice == 11)
            {
                WeatherBlock.Text = "11. Pouring Rain: It's raining, making the ball slippery and difficult to hold. A -1 modifier applies to all catch, intercept, or pick-up rolls.";
            }
            else if (WeatherDice == 12)
            {
                WeatherBlock.Text = "12. Blizzard: It's cold and snowing! The ice on the pitch means that any player attempting to move an extra square (GFI) will slip and be Knocked Down on a roll of 1-2, while the snow means that only quick or short passes can be attempted.";
            }
            else
            {
                WeatherBlock.Text = "4-10. Nice: Perfect Blood Bowl Weather.";
            }

        }
    }
}