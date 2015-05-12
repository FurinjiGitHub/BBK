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
            if (IsolatedStorageSettings.ApplicationSettings.Contains("userData"))
            {
                Fametin.Text = 
                IsolatedStorageSettings.ApplicationSettings["userData"] as string;
            }

            if (IsolatedStorageSettings.ApplicationSettings.Contains("userData2"))
            {
                WeatherTin.Text = "Current Weather: " +
                IsolatedStorageSettings.ApplicationSettings["userData2"] as string;
            }

            if (IsolatedStorageSettings.ApplicationSettings.Contains("userData3"))
            {
                KickTin.Text = "Kick-Off Table Result: " +
                IsolatedStorageSettings.ApplicationSettings["userData3"] as string;
            }

        }

    }
}