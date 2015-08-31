using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace WarCardGame.UI
{
    public partial class MainMenu : PhoneApplicationPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            //navigate to name input
            NavigationService.Navigate(new Uri("/PlayerNameInput.xaml", UriKind.Relative));
        }

        private void btnCustomize_Click(object sender, RoutedEventArgs e)
        {   //navigate to customize menu
            NavigationService.Navigate(new Uri("/CustomizeMenu.xaml", UriKind.Relative));
        }
        
    }
}