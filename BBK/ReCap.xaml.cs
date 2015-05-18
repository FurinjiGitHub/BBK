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
    public partial class ReCap : PhoneApplicationPage
    {
        public ReCap()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            //Sivulle tultaessa ladataan aikaisemmilla sivuilla tallennetut tiedot. Sovellus kerää vain ne tiedot, joilla on merkitystä pelaajille myöhemmin pelin kuluessa
            if (IsolatedStorageSettings.ApplicationSettings.Contains("userData"))
            {
                Fametin.Text = "Fan Advantage ModifiEr: \n" +
                IsolatedStorageSettings.ApplicationSettings["userData"] as string + "\r\n";
            }

            if (IsolatedStorageSettings.ApplicationSettings.Contains("userData2"))
            {
                WeatherTin.Text = "Weather Condition at the beginning was: \n" +
                IsolatedStorageSettings.ApplicationSettings["userData2"] as string + "\r\n";
            }

            if (IsolatedStorageSettings.ApplicationSettings.Contains("userData3"))
            {
                KickTin.Text = "Kick-Off Table result was: \n" +
                IsolatedStorageSettings.ApplicationSettings["userData3"] as string;
            }

        }

    }
}