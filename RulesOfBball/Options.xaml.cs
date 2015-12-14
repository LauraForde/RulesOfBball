﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RulesOfBball
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Options : Page
    {
        public Options()
        {
            this.InitializeComponent();
        }
        private void positionsBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Positions), UriKind.Relative);
        }

        private void foulsBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Fouls), UriKind.Relative);
        }

        private void violationsBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Violations), UriKind.Relative);
        }

        private void signalsBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Signals), UriKind.Relative);
        }
    }
}
