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
    public partial class Bounce6 : PhoneApplicationPage
    {
        public Bounce6()
        {
            InitializeComponent();
        }

        private void Rectangle_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BounceDirection.Text = "Direction: " + new Random().Next(1, 9).ToString();
        }
    }
}